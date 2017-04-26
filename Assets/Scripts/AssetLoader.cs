using System;
using UnityEngine;
using System.Collections;

public class AssetLoader : MonoBehaviour {


	public string BundleURL;//http://www.frobom.com/cinema/video_asset.file
	public string AssetName;
	public int version = 1;
	AssetBundle bundle;

	void Start() {
		StartCoroutine (DownloadAndCache());
	}

	IEnumerator DownloadAndCache (){

		yield return StartCoroutine(AssetBundleManager.downloadAssetBundle(BundleURL, version));

        bundle = AssetBundleManager.getAssetBundle(BundleURL, version);

		GameObject beta= Instantiate(bundle.LoadAsset("betadine002") as GameObject);
        
		//beta.transform.localScale = new Vector3(2, 1.8f,2);
		//beta.transform.position = new Vector3(0,-0.0175f,-0.02007f);
		beta.transform.parent = GameObject.Find("ImageTarget").transform;
        // icon.SetActive(false);
        // icon_obj = icon.transform;


        bundle.Unload(false);

    }
}
