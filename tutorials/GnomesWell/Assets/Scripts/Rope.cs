using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public GameObject ropeSegmentPrefab;

    //contains a list of rope segment objects
    List<GameObject> ropeSegments = new List<GameObject>();

    //are we currently extending or retracting the rope?
    public bool isIncreasing { get; set; }
    public bool isDecreasing { get; set; }

    //the rigidbody object that the end of the rope
    //should be attached to.
    public Rigidbody2D connectedObject;

    //the maximum length a rope segment should be (if we
    //need to extend by more than this, create a new rope
    //segment)
    public float maxRopeSegmentLength = 1.0f;

    //how quicklky we should pay out new rope
    public float ropeSpeed = 4.0f;

    //the linerenderer that renders the actual rope
    LineRenderer lineRenderer;



    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

        //reset tthe rope, so that we're ready to go.
        ResetLength();
    }

    //remove all rope segments, and create a new one.
    public void ResetLength()
    {
        foreach (GameObject segment in ropeSegments)
        {
            Destroy(segment);

        }

        ropeSegments = new List<GameObject>();

        isDecreasing = false;
        isIncreasing = false;

        CreateRopeSegment();
    }

    //attaches a new rope segmant at the top of the rope.

        void CreateRopeSegment()
    {
        //Create the new rope segment.
        GameObject segment = (GameObject)Instantiate(ropeSegmentPrefab, this.transform.position, Quaternion.identity);

        //make the rope segment be a child of this object,
        //and make it keep its world position
        segment.transform.SetParent(this.transform, true);

        //Get the rigid body from the segment
        Rigidbody2D segmentBody = segment.GetComponent<Rigidbody2D>();

        //get the distance joind from the segment
        SpringJoint2D segmentJoint = segment.GetComponent<SpringJoint2D>();

        //error if the segment prefab dosen't have a
        //rigidbody or spring joint - we need both
        if(segmentBody== null || segmentJoint == null)
        {
            Debug.LogError("Rope segment body prefab had no "+
                "Rigidbody2D and/or SpringJoint2D");
            return;
        }

        //Now that it's checked, add it to the start of the 
        //list of rope segments
        ropeSegments.Insert(0, segment);

        //if this is the first segment, it needs to
        //be connected to the gnome

        if (ropeSegments.Count == 1)
        {
            //connect the joint ot hte connected object to the
            //segment
            SpringJoint2D connectedObjectJoint =
                connectedObject.GetComponent<SpringJoint2D>();

            connectedObjectJoint.connectedBody =
                segmentBody;
            connectedObjectJoint.distance = 0.1f;

            //set this joint to already be at the max length
            segmentJoint.distance = maxRopeSegmentLength;
        }
        else
        {
            //this is an additional rope segment

            //get the second segment
            GameObject nextSegment = ropeSegments[1];

            //ge the joint htat we need to attach to
            SpringJoint2D nextSegmentJoint = nextSegment.GetComponent<SpringJoint2D>();

            //make this joint connect to us
            nextSegmentJoint.connectedBody = segmentBody;

            //make hte segment start at a distance of 0
            //units away from the previous one -it will
            //be extended
            segmentJoint.distance = 0.0f;
        }

        //connect the new segment to the rope ancor (ie to this object)
        segmentJoint.connectedBody = this.GetComponent<Rigidbody2D>();

    }

    //Called when we've shrunk the rope and need to remove a segment
    void RemoveRopeSegment()
    {
        //if we don't have two ro more segments, stop.
        if (ropeSegments.Count < 2)
        {
            return;
        }
    }


    // Update is called once per frame
    void Update()
    {
        //get the top segment and its joing.
        GameObject topSegment = ropeSegments[0];
        SpringJoint2D topSegmentJoint =
            topSegment.GetComponent<SpringJoint2D>();

        if (isIncreasing)
        {
            /*We're increasing the rope.
             * If it's not at max length
             * add a new segment; otherlsie
             * increase the top rope segment's length
             */
             if(topSegmentJoint.distance >= maxRopeSegmentLength)
            {
                CreateRopeSegment();
            }
            else
            {
                topSegmentJoint.distance += ropeSpeed * Time.deltaTime;
            }

        }

        if (isDecreasing)
        {
            if (topSegmentJoint.distance <= 0.005F)
            {
                RemoveRopeSegment();
            }
            else
            {
                topSegmentJoint.distance -= ropeSpeed * Time.deltaTime;
            }

        }

        if(lineRenderer != null) {
            /*The line render draws lines form
             * a collection of points. These points need to be keot
             * in sync with the positions of the rope segements.
             * 
             * The number or line render vartices =
             * number of rope segments, plusa a pont at the top
             * for the rope anchore, plus a point at the bottom for the gnome.
             */
            lineRenderer.positionCount = ropeSegments.Count + 2;

            //top vertiex is alaways at rhe rope's location
            lineRenderer.SetPosition(0, this.transform.position);
            
            /*For every rope segment we have, make the
             * corrosplonding line rnder vertex be at tis 
             * position
             */
             for(int i = 0; i< ropeSegments.Count; i++)
            {
                lineRenderer.SetPosition(i + 1, ropeSegments[i].transform.position);

            }

            SpringJoint2D connectedObjectJoint =
               connectedObject.GetComponent<SpringJoint2D>();
            lineRenderer.SetPosition(ropeSegments.Count + 1, connectedObject.transform.TransformPoint(connectedObjectJoint.anchor));

        }

        
    }
}
