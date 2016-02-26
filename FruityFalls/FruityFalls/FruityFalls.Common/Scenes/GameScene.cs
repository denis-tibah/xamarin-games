﻿using System;
using CocosSharp;
using FruityFalls.Entities;
using System.Collections.Generic;
using FruityFalls.Geometry;

namespace FruityFalls.Scenes
{
	public class GameScene : CCScene
	{
        CCLayer backgroundLayer;
		CCLayer gameplayLayer;
        CCLayer foregroundLayer;

        CCLayer hudLayer;

        int score = 0;
        ScoreText scoreText;

		Paddle paddle;
		List<Fruit> fruitList;

        Polygon binSplitter;

		FruitSpawner spawner;

        SolidRectangle splitter;

		List<FruitBin> fruitBins;
        private bool hasGameEnded;

        CCLabel debugLabel;

        public GameScene(CCGameView gameView) : base(gameView)
        {
            CreateLayers();

            fruitList = new List<Fruit>();

            CreateBackground();

            CreatePaddle();

            CreateBins();

            CreateForeground();

            CreateTouchListener();

            CreateHud();

            CreateSpawner();

            CreateDebugLabel();

            Schedule(Activity);

        }

        private void CreateForeground()
        {
            var foreground = new CCSprite("foreground.png");
            foreground.IsAntialiased = false;
            foreground.AnchorPoint = new CCPoint(0, 0);
            foregroundLayer.AddChild(foreground);
        }

        private void CreateDebugLabel()
        {
            debugLabel = new CCLabel("DebugLabel", "Arial", 20, CCLabelFormat.SystemFont);
            debugLabel.PositionX = hudLayer.ContentSize.Width/2.0f;
            debugLabel.PositionY = 650;
            debugLabel.HorizontalAlignment = CCTextAlignment.Left;
            if (GameCoefficients.ShowDebugInfo)
            {
                hudLayer.AddChild(debugLabel);
            }
        }

        private void CreateBackground()
        {
            var background = new CCSprite("background.png");
            background.AnchorPoint = new CCPoint(0, 0);
            background.IsAntialiased = false;
            backgroundLayer.AddChild(background);
        }

        private void CreateLayers()
        {
            backgroundLayer = new CCLayer();
            this.AddLayer(backgroundLayer);

            gameplayLayer = new CCLayer();
            this.AddLayer(gameplayLayer);

            foregroundLayer = new CCLayer();
            this.AddLayer(foregroundLayer);

            hudLayer = new CCLayer();
            this.AddLayer(hudLayer);
        }

        private void CreateSpawner()
        {
            spawner = new FruitSpawner();
            spawner.FruitSpawned += HandleFruitAdded;
            spawner.Layer = gameplayLayer;
        }

        private void CreateHud()
        {
            scoreText = new ScoreText();
            scoreText.PositionX = 10;
            scoreText.PositionY = hudLayer.ContentSize.Height - 30;
            scoreText.Score = 0;
            hudLayer.AddChild(scoreText);
        }

        private void CreatePaddle()
        {
            paddle = new Paddle();
            paddle.PositionX = gameplayLayer.ContentSize.Width / 2.0f;
            paddle.PositionY = gameplayLayer.ContentSize.Height / 2.0f;

            paddle.SetDesiredPositionToCurrentPosition();

            gameplayLayer.AddChild(paddle);
        }

        private void HandleFruitAdded(Fruit fruit)
		{
			fruitList.Add (fruit);
			gameplayLayer.AddChild (fruit);
		}

		private void CreateBins()
		{
			CCGeometryNode node;

			var gameView = base.GameView;

			fruitBins = new List<FruitBin>();
			
			// make 2 bins for now:
			var bin = new FruitBin ();
			bin.FruitColor = FruitColor.Red;
			bin.Width = gameView.ViewSize.Width / 2;
			fruitBins.Add (bin);
			gameplayLayer.AddChild(bin);

			bin = new FruitBin ();
			bin.FruitColor = FruitColor.Yellow;
			// todo: use the screen width to assign this:
			bin.PositionX = gameView.ViewSize.Width / 2;
			bin.Width = gameView.ViewSize.Width / 2;
			fruitBins.Add (bin);
			gameplayLayer.AddChild(bin);

            splitter = new SolidRectangle(20, GameCoefficients.SplitterHeight);
            splitter.PositionX = gameplayLayer.ContentSize.Width / 2.0f;
            splitter.PositionY = GameCoefficients.SplitterHeight/2.0f;
            splitter.Visible = false;
            gameplayLayer.AddChild(splitter);
		}

		private void CreateTouchListener()
		{
			var touchListener = new CCEventListenerTouchAllAtOnce ();
			touchListener.OnTouchesMoved = HandleTouchesMoved;
            touchListener.OnTouchesBegan = HandleTouchesBegan;
			gameplayLayer.AddEventListener (touchListener);
		}

        private void HandleTouchesBegan(List<CCTouch> arg1, CCEvent arg2)
        {
            if(hasGameEnded)
            {
                var newScene = new TitleScene(GameController.GameView);
                GameController.GoToScene(newScene);
            }
        }

        void HandleTouchesMoved (System.Collections.Generic.List<CCTouch> touches, CCEvent touchEvent)
		{
			// we only care about the first touch:
			var locationOnScreen = touches [0].Location;

			paddle.HandleInput (locationOnScreen);
		}

		private void Activity(float frameTimeInSeconds)
		{
            if (hasGameEnded == false)
            {
                paddle.Activity(frameTimeInSeconds);

                foreach (var fruit in fruitList)
                {
                    fruit.Activity(frameTimeInSeconds);
                }

                spawner.Activity(frameTimeInSeconds);

                DebugActivity();

                PerformCollision();
            }
		}

        private void DebugActivity()
        {
            if(GameCoefficients.ShowDebugInfo)
            {
                debugLabel.Text = spawner.DebugInfo;
            }
        }

        private void PerformCollision()
		{
            // reverse for loop since fruit may be destroyed:
            for(int i = fruitList.Count - 1; i > -1; i--)
            {
                var fruit = fruitList[i];

                bool didCollideWithPaddle = FruitPolygonCollision(fruit, paddle.Polygon, paddle.Velocity);
                if(didCollideWithPaddle)
                {
                    fruit.TryAddExtraPointValue();
                }

                FruitPolygonCollision(fruit, splitter.Polygon, CCPoint.Zero);

                FruitVsBorders(fruit);

                FruitVsBins(fruit);
            }
		}

        private void FruitVsBins(Fruit fruit)
        {
            foreach(var bin in fruitBins)
            {
                if(bin.Polygon.CollideAgainst(fruit.Collision))
                {
                    if(bin.FruitColor == fruit.FruitColor)
                    {
                        // award points:
                        score += 1 + fruit.ExtraPointValue;
                        scoreText.Score = score;
                    }
                    else
                    {
                        EndGame();
                    }

                    Destroy(fruit);

                    break;
                }
            }

        }

        private void EndGame()
        {
            hasGameEnded = true;
            spawner.IsSpawning = false;
            paddle.Visible = false;


			// dim the background:
			var drawNode = new CCDrawNode();
			drawNode.DrawRect(
				new CCRect (0,0, 2000, 2000),
				new CCColor4B(0,0,0,160));
			hudLayer.Children.Add(drawNode);


            var endGameLabel = new CCLabel("Game Over\nFinal Score:" + score,
				"Arial", 40, CCLabelFormat.SystemFont);
            endGameLabel.HorizontalAlignment = CCTextAlignment.Center;
			endGameLabel.Color = CCColor3B.White;
            endGameLabel.VerticalAlignment = CCVerticalTextAlignment.Center;
            endGameLabel.PositionX = hudLayer.ContentSize.Width / 2.0f;
            endGameLabel.PositionY = hudLayer.ContentSize.Height / 2.0f;
            hudLayer.Children.Add(endGameLabel);

        }

        private void Destroy(Fruit fruit)
        {
            fruit.RemoveFromParent();
            fruitList.Remove(fruit);
        }

        private static bool FruitPolygonCollision(Fruit fruit, Polygon polygon, CCPoint polygonVelocity)
        {
            bool didCollide = polygon.CollideAgainst(fruit.Collision);

            if (didCollide)
            {
                bool isCircleCenterInPolygon = polygon.IsPointInside(
                                                   fruit.PositionWorldspace.X, fruit.PositionWorldspace.Y);

                float distance;
                var normal = polygon.GetNormalClosestTo(fruit.PositionWorldspace, out distance);

                if (isCircleCenterInPolygon)
                {
                    distance += fruit.Radius;
                }
                else
                {
                    distance = fruit.Radius - distance;
                }

                // increase the distance by a small amount to make sure that the objects do separate:
                distance += .5f;

                fruit.Position += normal * distance;

                fruit.Velocity = ApplyBounce(fruit.Velocity, polygonVelocity, normal, GameCoefficients.FruitCollisionElasticity);

            }
            return didCollide;
        }

        private void FruitVsBorders(Fruit fruit)
        {
            if(fruit.PositionX - fruit.Radius < 0 && fruit.Velocity.X < 0)
            {
                fruit.Velocity.X *= -1 * GameCoefficients.FruitCollisionElasticity;
            }
            if(fruit.PositionX + fruit.Radius > gameplayLayer.ContentSize.Width && fruit.Velocity.X > 0)
            {
                fruit.Velocity.X *= -1 * GameCoefficients.FruitCollisionElasticity;
            }
            if(fruit.PositionY + fruit.Radius > gameplayLayer.ContentSize.Height && fruit.Velocity.Y > 0)
            {
                fruit.Velocity.Y *= -1 * GameCoefficients.FruitCollisionElasticity;
            }
        }

        private static CCPoint ApplyBounce(CCPoint object1Velocity, CCPoint object2Velocity, CCPoint normal, float elasticity)
        {
            CCPoint vectorAsVelocity = new CCPoint(
               object1Velocity.X - object2Velocity.X,
               object1Velocity.Y - object2Velocity.Y);
            
            float projected = CCPoint.Dot(vectorAsVelocity, normal);

            if (projected < 0)
            {
                CCPoint velocityComponentPerpendicularToTangent =
                    normal * projected;

                object1Velocity.X -= (1 + elasticity)  * velocityComponentPerpendicularToTangent.X;
                object1Velocity.Y -= (1 + elasticity)  * velocityComponentPerpendicularToTangent.Y;

            }

            return object1Velocity;
        }



        private CCPoint Reflect(CCPoint vectorToReflect, CCPoint surfaceToReflectOn)
		{
			surfaceToReflectOn.Normalize();


			CCPoint projected = surfaceToReflectOn * CCPoint.Dot(vectorToReflect, surfaceToReflectOn);

			return -(vectorToReflect - projected) + projected;

		}

	}
}

