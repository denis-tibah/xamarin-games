using System;

namespace GLKeysES30
{
	public class KeyModel
	{
		internal readonly static float[] vertices = {
			0.750000f, 1.000000f, 0.000000f, 0.056795f, 0.721702f, -0.689840f, 0.000000f, 0.000000f,
			0.750000f, 1.000000f, 0.250000f, 0.078249f, 0.991913f, 0.099857f, 0.000000f, 0.000000f,
			0.827255f, 0.987764f, 0.250000f, 0.307566f, 0.946013f, 0.101993f, 0.000000f, 0.000000f,
			0.827254f, 0.987764f, 0.000000f, 0.228401f, 0.702963f, -0.673513f, 0.000000f, 0.000000f,
			1.000000f, -0.750000f, 0.000000f, 0.721702f, -0.056795f, -0.689840f, 0.000000f, 0.000000f,
			0.999999f, -0.750001f, 0.250000f, 0.991913f, -0.078249f, 0.099857f, 0.000000f, 0.000000f,
			0.987764f, -0.827255f, 0.250000f, 0.946013f, -0.307566f, 0.101993f, 0.000000f, 0.000000f,
			0.987764f, -0.827254f, 0.000000f, 0.702963f, -0.228401f, -0.673513f, 0.000000f, 0.000000f,
			-0.750000f, -1.000000f, 0.000000f, -0.056795f, -0.721702f, -0.689840f, 0.000000f, 0.000000f,
			-0.750000f, -1.000000f, 0.250000f, -0.078249f, -0.991913f, 0.099857f, 0.000000f, 0.000000f,
			-0.827255f, -0.987764f, 0.250000f, -0.307566f, -0.946013f, 0.101993f, 0.000000f, 0.000000f,
			-0.827254f, -0.987764f, 0.000000f, -0.228401f, -0.702963f, -0.673513f, 0.000000f, 0.000000f,
			0.987764f, 0.827254f, 0.000000f, 0.702963f, 0.228401f, -0.673513f, 0.000000f, 0.000000f,
			0.987765f, 0.827254f, 0.250000f, 0.946013f, 0.307566f, 0.101993f, 0.000000f, 0.000000f,
			1.000000f, 0.749999f, 0.250000f, 0.991913f, 0.078249f, 0.099857f, 0.000000f, 0.000000f,
			1.000000f, 0.750000f, 0.000000f, 0.721702f, 0.056795f, -0.689840f, 0.000000f, 0.000000f,
			-0.750000f, 1.000000f, 0.000000f, -0.056795f, 0.721702f, -0.689840f, 0.000000f, 0.000000f,
			-0.750000f, 1.000000f, 0.250000f, -0.078249f, 0.991913f, 0.099857f, 0.000000f, 0.000000f,
			0.952254f, 0.896946f, 0.000000f, 0.597980f, 0.434462f, -0.673513f, 0.000000f, 0.000000f,
			0.952255f, 0.896946f, 0.250000f, 0.804712f, 0.584643f, 0.102878f, 0.000000f, 0.000000f,
			0.827254f, -0.987764f, 0.000000f, 0.228401f, -0.702963f, -0.673513f, 0.000000f, 0.000000f,
			0.827254f, -0.987765f, 0.250000f, 0.307566f, -0.946013f, 0.101993f, 0.000000f, 0.000000f,
			0.749999f, -1.000000f, 0.250000f, 0.078249f, -0.991913f, 0.099857f, 0.000000f, 0.000000f,
			0.750000f, -1.000000f, 0.000000f, 0.056795f, -0.721702f, -0.689840f, 0.000000f, 0.000000f,
			0.896947f, 0.952254f, 0.250000f, 0.584643f, 0.804712f, 0.102878f, 0.000000f, 0.000000f,
			0.896946f, 0.952254f, 0.000000f, 0.434462f, 0.597980f, -0.673513f, 0.000000f, 0.000000f,
			0.896946f, -0.952254f, 0.000000f, 0.434462f, -0.597980f, -0.673513f, 0.000000f, 0.000000f,
			0.896946f, -0.952255f, 0.250000f, 0.584643f, -0.804712f, 0.102878f, 0.000000f, 0.000000f,
			-0.987764f, -0.827254f, 0.000000f, -0.702963f, -0.228401f, -0.673513f, 0.000000f, 0.000000f,
			-0.987764f, -0.827254f, 0.250000f, -0.946013f, -0.307566f, 0.101993f, 0.000000f, 0.000000f,
			-1.000000f, -0.750000f, 0.250000f, -0.991913f, -0.078249f, 0.099857f, 0.000000f, 0.000000f,
			-1.000000f, -0.750000f, 0.000000f, -0.721702f, -0.056795f, -0.689840f, 0.000000f, 0.000000f,
			0.952254f, -0.896947f, 0.250000f, 0.804712f, -0.584643f, 0.102878f, 0.000000f, 0.000000f,
			0.952254f, -0.896946f, 0.000000f, 0.597980f, -0.434462f, -0.673513f, 0.000000f, 0.000000f,
			-0.952254f, -0.896946f, 0.000000f, -0.597980f, -0.434462f, -0.673513f, 0.000000f, 0.000000f,
			-0.952255f, -0.896946f, 0.250000f, -0.804712f, -0.584643f, 0.102878f, 0.000000f, 0.000000f,
			-0.827254f, 0.987764f, 0.000000f, -0.228401f, 0.702963f, -0.673513f, 0.000000f, 0.000000f,
			-0.827254f, 0.987764f, 0.250000f, -0.307566f, 0.946013f, 0.101993f, 0.000000f, 0.000000f,
			-0.896947f, -0.952254f, 0.250000f, -0.584643f, -0.804712f, 0.102878f, 0.000000f, 0.000000f,
			-0.896946f, -0.952254f, 0.000000f, -0.434462f, -0.597980f, -0.673513f, 0.000000f, 0.000000f,
			-1.000000f, 0.750000f, 0.250000f, -0.991913f, 0.078249f, 0.099857f, 0.000000f, 0.000000f,
			-1.000000f, 0.750000f, 0.000000f, -0.721702f, 0.056795f, -0.689840f, 0.000000f, 0.000000f,
			-0.896946f, 0.952255f, 0.000000f, -0.434462f, 0.597980f, -0.673513f, 0.000000f, 0.000000f,
			-0.896946f, 0.952254f, 0.250000f, -0.584643f, 0.804712f, 0.102878f, 0.000000f, 0.000000f,
			-0.987764f, 0.827255f, 0.000000f, -0.702963f, 0.228401f, -0.673513f, 0.000000f, 0.000000f,
			-0.987764f, 0.827254f, 0.250000f, -0.946013f, 0.307566f, 0.101993f, 0.000000f, 0.000000f,
			-0.952254f, 0.896946f, 0.250000f, -0.804712f, 0.584643f, 0.102878f, 0.000000f, 0.000000f,
			-0.952254f, 0.896947f, 0.000000f, -0.597980f, 0.434462f, -0.673513f, 0.000000f, 0.000000f,
			0.746066f, 0.950000f, 0.300000f, 0.008118f, 0.102634f, 0.994659f, 0.000000f, 0.000000f,
			0.811611f, 0.939618f, 0.300000f, 0.033204f, 0.101962f, 0.994201f, 0.000000f, 0.000000f,
			0.817539f, 0.957862f, 0.296194f, 0.122959f, 0.377026f, 0.917966f, 0.000000f, 0.000000f,
			0.747568f, 0.969087f, 0.296194f, 0.031068f, 0.389569f, 0.920438f, 0.000000f, 0.000000f,
			0.822594f, 0.973418f, 0.285355f, 0.220832f, 0.677114f, 0.701926f, 0.000000f, 0.000000f,
			0.748843f, 0.985291f, 0.285355f, 0.056520f, 0.708518f, 0.703391f, 0.000000f, 0.000000f,
			0.826005f, 0.983918f, 0.269134f, 0.285867f, 0.877834f, 0.384228f, 0.000000f, 0.000000f,
			0.749697f, 0.996146f, 0.269134f, 0.073122f, 0.920957f, 0.382672f, 0.000000f, 0.000000f,
			0.867191f, 0.911299f, 0.300000f, 0.063143f, 0.086917f, 0.994201f, 0.000000f, 0.000000f,
			0.878466f, 0.926818f, 0.296194f, 0.233314f, 0.321146f, 0.917814f, 0.000000f, 0.000000f,
			0.888081f, 0.940051f, 0.285355f, 0.418592f, 0.576159f, 0.701956f, 0.000000f, 0.000000f,
			0.894570f, 0.948983f, 0.269134f, 0.542375f, 0.746544f, 0.385296f, 0.000000f, 0.000000f,
			0.911300f, 0.867190f, 0.300000f, 0.086917f, 0.063143f, 0.994201f, 0.000000f, 0.000000f,
			0.926819f, 0.878466f, 0.296194f, 0.321146f, 0.233314f, 0.917814f, 0.000000f, 0.000000f,
			0.940052f, 0.888080f, 0.285355f, 0.576159f, 0.418592f, 0.701956f, 0.000000f, 0.000000f,
			0.948983f, 0.894569f, 0.269134f, 0.746544f, 0.542375f, 0.385296f, 0.000000f, 0.000000f,
			0.939619f, 0.811610f, 0.300000f, 0.101962f, 0.033204f, 0.994201f, 0.000000f, 0.000000f,
			0.957863f, 0.817538f, 0.296194f, 0.377026f, 0.122959f, 0.917966f, 0.000000f, 0.000000f,
			0.973419f, 0.822593f, 0.285355f, 0.677114f, 0.220832f, 0.701926f, 0.000000f, 0.000000f,
			0.983919f, 0.826004f, 0.269134f, 0.877834f, 0.285867f, 0.384228f, 0.000000f, 0.000000f,
			0.950000f, 0.746065f, 0.300000f, 0.102634f, 0.008118f, 0.994659f, 0.000000f, 0.000000f,
			0.969087f, 0.747567f, 0.296194f, 0.389569f, 0.031068f, 0.920438f, 0.000000f, 0.000000f,
			0.985292f, 0.748842f, 0.285355f, 0.708518f, 0.056520f, 0.703391f, 0.000000f, 0.000000f,
			0.996147f, 0.749696f, 0.269134f, 0.920957f, 0.073122f, 0.382672f, 0.000000f, 0.000000f,
			0.949999f, -0.746066f, 0.300000f, 0.102634f, -0.008118f, 0.994659f, 0.000000f, 0.000000f,
			0.939618f, -0.811611f, 0.300000f, 0.101962f, -0.033204f, 0.994201f, 0.000000f, 0.000000f,
			0.957862f, -0.817539f, 0.296194f, 0.377026f, -0.122959f, 0.917966f, 0.000000f, 0.000000f,
			0.969086f, -0.747568f, 0.296194f, 0.389569f, -0.031068f, 0.920438f, 0.000000f, 0.000000f,
			0.973418f, -0.822594f, 0.285355f, 0.677114f, -0.220832f, 0.701926f, 0.000000f, 0.000000f,
			0.985291f, -0.748843f, 0.285355f, 0.708518f, -0.056520f, 0.703391f, 0.000000f, 0.000000f,
			0.983918f, -0.826005f, 0.269134f, 0.877834f, -0.285867f, 0.384228f, 0.000000f, 0.000000f,
			0.996146f, -0.749697f, 0.269134f, 0.920957f, -0.073122f, 0.382672f, 0.000000f, 0.000000f,
			0.911299f, -0.867191f, 0.300000f, 0.086917f, -0.063143f, 0.994201f, 0.000000f, 0.000000f,
			0.926818f, -0.878466f, 0.296194f, 0.321146f, -0.233314f, 0.917814f, 0.000000f, 0.000000f,
			0.940051f, -0.888081f, 0.285355f, 0.576159f, -0.418592f, 0.701956f, 0.000000f, 0.000000f,
			0.948983f, -0.894570f, 0.269134f, 0.746544f, -0.542375f, 0.385296f, 0.000000f, 0.000000f,
			0.867190f, -0.911300f, 0.300000f, 0.063143f, -0.086917f, 0.994201f, 0.000000f, 0.000000f,
			0.878465f, -0.926819f, 0.296194f, 0.233314f, -0.321146f, 0.917814f, 0.000000f, 0.000000f,
			0.888080f, -0.940052f, 0.285355f, 0.418592f, -0.576159f, 0.701956f, 0.000000f, 0.000000f,
			0.894569f, -0.948984f, 0.269134f, 0.542375f, -0.746544f, 0.385296f, 0.000000f, 0.000000f,
			0.811610f, -0.939619f, 0.300000f, 0.033204f, -0.101962f, 0.994201f, 0.000000f, 0.000000f,
			0.817538f, -0.957863f, 0.296194f, 0.122959f, -0.377026f, 0.917966f, 0.000000f, 0.000000f,
			0.822592f, -0.973419f, 0.285355f, 0.220832f, -0.677114f, 0.701926f, 0.000000f, 0.000000f,
			0.826004f, -0.983919f, 0.269134f, 0.285867f, -0.877834f, 0.384228f, 0.000000f, 0.000000f,
			0.746064f, -0.950000f, 0.300000f, 0.008118f, -0.102634f, 0.994659f, 0.000000f, 0.000000f,
			0.747566f, -0.969087f, 0.296194f, 0.031068f, -0.389569f, 0.920438f, 0.000000f, 0.000000f,
			0.748842f, -0.985292f, 0.285355f, 0.056520f, -0.708518f, 0.703391f, 0.000000f, 0.000000f,
			0.749696f, -0.996147f, 0.269134f, 0.073122f, -0.920957f, 0.382672f, 0.000000f, 0.000000f,
			-0.746065f, -0.950000f, 0.300000f, -0.008118f, -0.102634f, 0.994659f, 0.000000f, 0.000000f,
			-0.811611f, -0.939618f, 0.300000f, -0.033204f, -0.101962f, 0.994201f, 0.000000f, 0.000000f,
			-0.817539f, -0.957862f, 0.296194f, -0.122959f, -0.377026f, 0.917966f, 0.000000f, 0.000000f,
			-0.747567f, -0.969087f, 0.296194f, -0.031068f, -0.389569f, 0.920438f, 0.000000f, 0.000000f,
			-0.822593f, -0.973418f, 0.285355f, -0.220832f, -0.677114f, 0.701926f, 0.000000f, 0.000000f,
			-0.748843f, -0.985291f, 0.285355f, -0.056520f, -0.708518f, 0.703391f, 0.000000f, 0.000000f,
			-0.826005f, -0.983918f, 0.269134f, -0.285867f, -0.877834f, 0.384228f, 0.000000f, 0.000000f,
			-0.749697f, -0.996146f, 0.269134f, -0.073122f, -0.920957f, 0.382672f, 0.000000f, 0.000000f,
			-0.867191f, -0.911299f, 0.300000f, -0.063143f, -0.086917f, 0.994201f, 0.000000f, 0.000000f,
			-0.878466f, -0.926818f, 0.296194f, -0.233314f, -0.321146f, 0.917814f, 0.000000f, 0.000000f,
			-0.888081f, -0.940051f, 0.285355f, -0.418592f, -0.576159f, 0.701956f, 0.000000f, 0.000000f,
			-0.894570f, -0.948983f, 0.269134f, -0.542375f, -0.746544f, 0.385296f, 0.000000f, 0.000000f,
			-0.911299f, -0.867190f, 0.300000f, -0.086917f, -0.063143f, 0.994201f, 0.000000f, 0.000000f,
			-0.926819f, -0.878466f, 0.296194f, -0.321146f, -0.233314f, 0.917814f, 0.000000f, 0.000000f,
			-0.940051f, -0.888080f, 0.285355f, -0.576159f, -0.418592f, 0.701956f, 0.000000f, 0.000000f,
			-0.948983f, -0.894569f, 0.269134f, -0.746544f, -0.542375f, 0.385296f, 0.000000f, 0.000000f,
			-0.939619f, -0.811610f, 0.300000f, -0.101962f, -0.033204f, 0.994201f, 0.000000f, 0.000000f,
			-0.957863f, -0.817538f, 0.296194f, -0.377026f, -0.122990f, 0.917966f, 0.000000f, 0.000000f,
			-0.973419f, -0.822593f, 0.285355f, -0.677114f, -0.220832f, 0.701926f, 0.000000f, 0.000000f,
			-0.983919f, -0.826004f, 0.269134f, -0.877834f, -0.285867f, 0.384228f, 0.000000f, 0.000000f,
			-0.950000f, -0.746065f, 0.300000f, -0.102634f, -0.008118f, 0.994659f, 0.000000f, 0.000000f,
			-0.969087f, -0.747567f, 0.296194f, -0.389569f, -0.031068f, 0.920438f, 0.000000f, 0.000000f,
			-0.985292f, -0.748842f, 0.285355f, -0.708518f, -0.056520f, 0.703391f, 0.000000f, 0.000000f,
			-0.996147f, -0.749696f, 0.269134f, -0.920957f, -0.073122f, 0.382672f, 0.000000f, 0.000000f,
			-0.950000f, 0.746065f, 0.300000f, -0.102634f, 0.008118f, 0.994659f, 0.000000f, 0.000000f,
			-0.939619f, 0.811611f, 0.300000f, -0.101962f, 0.033204f, 0.994201f, 0.000000f, 0.000000f,
			-0.957863f, 0.817538f, 0.296194f, -0.377026f, 0.122959f, 0.917966f, 0.000000f, 0.000000f,
			-0.969087f, 0.747567f, 0.296194f, -0.389569f, 0.031068f, 0.920438f, 0.000000f, 0.000000f,
			-0.973419f, 0.822593f, 0.285355f, -0.677114f, 0.220832f, 0.701926f, 0.000000f, 0.000000f,
			-0.985292f, 0.748843f, 0.285355f, -0.708518f, 0.056520f, 0.703391f, 0.000000f, 0.000000f,
			-0.983919f, 0.826005f, 0.269134f, -0.877834f, 0.285867f, 0.384228f, 0.000000f, 0.000000f,
			-0.996147f, 0.749697f, 0.269134f, -0.920957f, 0.073122f, 0.382672f, 0.000000f, 0.000000f,
			-0.911299f, 0.867191f, 0.300000f, -0.086917f, 0.063143f, 0.994201f, 0.000000f, 0.000000f,
			-0.926818f, 0.878466f, 0.296194f, -0.321146f, 0.233314f, 0.917814f, 0.000000f, 0.000000f,
			-0.940051f, 0.888080f, 0.285355f, -0.576159f, 0.418592f, 0.701956f, 0.000000f, 0.000000f,
			-0.948983f, 0.894570f, 0.269134f, -0.746544f, 0.542375f, 0.385296f, 0.000000f, 0.000000f,
			-0.867191f, 0.911299f, 0.300000f, -0.063143f, 0.086917f, 0.994201f, 0.000000f, 0.000000f,
			-0.878466f, 0.926818f, 0.296194f, -0.233314f, 0.321146f, 0.917814f, 0.000000f, 0.000000f,
			-0.888080f, 0.940051f, 0.285355f, -0.418592f, 0.576159f, 0.701956f, 0.000000f, 0.000000f,
			-0.894570f, 0.948983f, 0.269134f, -0.542375f, 0.746544f, 0.385296f, 0.000000f, 0.000000f,
			-0.811611f, 0.939619f, 0.300000f, -0.033204f, 0.101962f, 0.994201f, 0.000000f, 0.000000f,
			-0.817539f, 0.957862f, 0.296194f, -0.122959f, 0.377026f, 0.917966f, 0.000000f, 0.000000f,
			-0.822593f, 0.973419f, 0.285355f, -0.220832f, 0.677114f, 0.701926f, 0.000000f, 0.000000f,
			-0.826005f, 0.983919f, 0.269134f, -0.285867f, 0.877834f, 0.384228f, 0.000000f, 0.000000f,
			-0.746065f, 0.950000f, 0.300000f, -0.008118f, 0.102634f, 0.994659f, 0.000000f, 0.000000f,
			-0.747567f, 0.969087f, 0.296194f, -0.031068f, 0.389569f, 0.920438f, 0.000000f, 0.000000f,
			-0.748842f, 0.985291f, 0.285355f, -0.056520f, 0.708518f, 0.703391f, 0.000000f, 0.000000f,
			-0.749697f, 0.996147f, 0.269134f, -0.073122f, 0.920957f, 0.382672f, 0.000000f, 0.000000f,
		};

		internal static readonly ushort[] faceIndexes = {
			0, 1, 2, 0, 2, 3, 4, 5, 6, 4, 6, 7, 8, 9, 10, 8, 10, 11, 12, 13, 14, 12, 14, 15, 1, 0, 16, 1, 16, 17, 18, 19, 13, 18, 13, 12, 20, 21, 22, 20, 22, 23, 3, 2, 24, 3, 24, 25, 25, 24, 19, 25, 19, 18, 15, 14, 5, 15, 5, 4, 26, 27, 21, 26, 21, 20, 28, 29, 30, 28, 30, 31, 7, 6, 32, 7, 32, 33, 33, 32, 27, 33, 27, 26, 23, 22, 9, 23, 9, 8, 34, 35, 29, 34, 29, 28, 36, 37, 17, 36, 17, 16, 11, 10, 38, 11, 38, 39, 39, 38, 35, 39, 35, 34, 31, 30, 40, 31, 40, 41, 42, 43, 37, 42, 37, 36, 44, 45, 46, 44, 46, 47, 47, 46, 43, 47, 43, 42, 41, 40, 45, 41, 45, 44, 0, 36, 16, 0, 3, 36, 3, 42, 36, 3, 25, 42, 25, 47, 42, 25, 18, 47, 18, 44, 47, 18, 12, 44, 12, 41, 44, 12, 15, 41, 15, 31, 41, 15, 4, 31, 4, 28, 31, 4, 7, 28, 7, 34, 28, 7, 33, 34, 33, 39, 34, 33, 26, 39, 26, 11, 39, 26, 20, 11, 20, 8, 11, 20, 23, 8, 48, 49, 50, 48, 50, 51, 51, 50, 52, 51, 52, 53, 53, 52, 54, 53, 54, 55, 55, 54, 2, 55, 2, 1, 49, 56, 57, 49, 57, 50, 50, 57, 58, 50, 58, 52, 52, 58, 59, 52, 59, 54, 54, 59, 24, 54, 24, 2, 56, 60, 61, 56, 61, 57, 57, 61, 62, 57, 62, 58, 58, 62, 63, 58, 63, 59, 59, 63, 19, 59, 19, 24, 60, 64, 65, 60, 65, 61, 61, 65, 66, 61, 66, 62, 62, 66, 67, 62, 67, 63, 63, 67, 13, 63, 13, 19, 64, 68, 69, 64, 69, 65, 65, 69, 70, 65, 70, 66, 66, 70, 71, 66, 71, 67, 67, 71, 14, 67, 14, 13, 72, 73, 74, 72, 74, 75, 75, 74, 76, 75, 76, 77, 77, 76, 78, 77, 78, 79, 79, 78, 6, 79, 6, 5, 73, 80, 81, 73, 81, 74, 74, 81, 82, 74, 82, 76, 76, 82, 83, 76, 83, 78, 78, 83, 32, 78, 32, 6, 80, 84, 85, 80, 85, 81, 81, 85, 86, 81, 86, 82, 82, 86, 87, 82, 87, 83, 83, 87, 27, 83, 27, 32, 84, 88, 89, 84, 89, 85, 85, 89, 90, 85, 90, 86, 86, 90, 91, 86, 91, 87, 87, 91, 21, 87, 21, 27, 88, 92, 93, 88, 93, 89, 89, 93, 94, 89, 94, 90, 90, 94, 95, 90, 95, 91, 91, 95, 22, 91, 22, 21, 96, 97, 98, 96, 98, 99, 99, 98, 100, 99, 100, 101, 101, 100, 102, 101, 102, 103, 103, 102, 10, 103, 10, 9, 97, 104, 105, 97, 105, 98, 98, 105, 106, 98, 106, 100, 100, 106, 107, 100, 107, 102, 102, 107, 38, 102, 38, 10, 104, 108, 109, 104, 109, 105, 105, 109, 110, 105, 110, 106, 106, 110, 111, 106, 111, 107, 107, 111, 35, 107, 35, 38, 108, 112, 113, 108, 113, 109, 109, 113, 114, 109, 114, 110, 110, 114, 115, 110, 115, 111, 111, 115, 29, 111, 29, 35, 112, 116, 117, 112, 117, 113, 113, 117, 118, 113, 118, 114, 114, 118, 119, 114, 119, 115, 115, 119, 30, 115, 30, 29, 120, 121, 122, 120, 122, 123, 123, 122, 124, 123, 124, 125, 125, 124, 126, 125, 126, 127, 127, 126, 45, 127, 45, 40, 121, 128, 129, 121, 129, 122, 122, 129, 130, 122, 130, 124, 124, 130, 131, 124, 131, 126, 126, 131, 46, 126, 46, 45, 128, 132, 133, 128, 133, 129, 129, 133, 134, 129, 134, 130, 130, 134, 135, 130, 135, 131, 131, 135, 43, 131, 43, 46, 132, 136, 137, 132, 137, 133, 133, 137, 138, 133, 138, 134, 134, 138, 139, 134, 139, 135, 135, 139, 37, 135, 37, 43, 136, 140, 141, 136, 141, 137, 137, 141, 142, 137, 142, 138, 138, 142, 143, 138, 143, 139, 139, 143, 17, 139, 17, 37, 140, 48, 51, 140, 51, 141, 141, 51, 53, 141, 53, 142, 142, 53, 55, 142, 55, 143, 143, 55, 1, 143, 1, 17, 68, 72, 75, 68, 75, 69, 69, 75, 77, 69, 77, 70, 70, 77, 79, 70, 79, 71, 71, 79, 5, 71, 5, 14, 92, 96, 99, 92, 99, 93, 93, 99, 101, 93, 101, 94, 94, 101, 103, 94, 103, 95, 95, 103, 9, 95, 9, 22, 116, 120, 123, 116, 123, 117, 117, 123, 125, 117, 125, 118, 118, 125, 127, 118, 127, 119, 119, 127, 40, 119, 40, 30, 48, 140, 136, 49, 48, 136, 49, 136, 132, 56, 49, 132, 56, 132, 128, 60, 56, 128, 60, 128, 121, 64, 60, 121, 64, 121, 120, 68, 64, 120, 68, 120, 116, 68, 116, 72, 116, 112, 72, 112, 73, 72, 112, 108, 73, 108, 80, 73, 108, 104, 80, 104, 84, 80, 104, 97, 84, 97, 88, 84, 97, 96, 88, 96, 92, 88,
		};
	}	
}
