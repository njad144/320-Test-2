using UnityEngine;
using Pathfinding.Serialization.JsonFx; //make sure you include this using

public class Sketch : MonoBehaviour {
    public GameObject myPrefab;
    public string _WebsiteURL = "http://infosys320mondaynjad144.azurewebsites.net/tables/TreeSurvey?zumo-api-version=2.0.0";

    void Start () {
        //Reguest.GET can be called passing in your ODATA url as a string in the form:
        //http://{Your Site Name}.azurewebsites.net/tables/{Your Table Name}?zumo-api-version=2.0.0
        //The response produce is a JSON string
        string jsonResponse = Request.GET(_WebsiteURL);

        //Just in case something went wrong with the request we check the reponse and exit if there is no response.
        if (string.IsNullOrEmpty(jsonResponse))
        {
            return;
        }

        //We can now deserialize into an array of objects - in this case the class we created. The deserializer is smart enough to instantiate all the classes and populate the variables based on column name.
        Tree[] trees = JsonReader.Deserialize<Tree[]>(jsonResponse);

        //----------------------
        //YOU WILL NEED TO DECLARE SOME VARIABLES HERE SIMILAR TO THE CREATIVE CODING TUTORIAL



        //----------------------

        //We can now loop through the array of objects and access each object individually
        foreach (Tree tree in trees)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(float.Parse(tree.X), float.Parse(tree.Y), float.Parse(tree.Z));
            cube.transform.localScale = new Vector3((float)0.2, (float)0.2, (float)0.2);
            //cube.GetComponentInChildren<TextMesh>().text = tree.Location;
            //cube.AddComponent<TextMesh>().text = tree.Location;

            //Example of how to use the object
            Debug.Log("This trees ID is: " + tree.TreeID);
            //----------------------
            //YOUR CODE TO INSTANTIATE NEW PREFABS GOES HERE


                

            //----------------------
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
