using System.Collections;
using UnityEngine;
using UnityEditor;

public class AssetBundleCreate : MonoBehaviour {

	[MenuItem ("Assets/Build AssetBundles")]

	static void BuildAllAssetBundles()
	{
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles", BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
	}
}
