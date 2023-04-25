using UnityEngine;
using TMPro;
using System.Collections;
using System;

namespace PathCreation.Examples
{
    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class PathFollower : MonoBehaviour
    {
        public PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        private float speed = 0;
        public float baseSpeed = 5;
        float distanceTravelled;
        float speedAdjustment;
        public TextMeshPro speedText;
        public static Action<Vector3> startingPos;
        private bool sendStartPosition;
        void Start() {
            if (pathCreator != null)
            {
                // Subscribed to the pathUpdated event so that we're notified if the path changes during the game
                pathCreator.pathUpdated += OnPathChanged;
            }
            SpeedSetter.ActivateSpeedSetter();
            ExternalSpeedAdjustment.speedAdjustment += (value) => { speedAdjustment = value; };
            speed = SpeedSetter.speedActual + baseSpeed;
            StartCoroutine(SpeedAdjust());
            sendStartPosition = true;
        }

        void Update()
        {
            StartCoroutine(SpeedAdjust());
            if (pathCreator != null)
            {                        
                speedText.text = "Car Speed: " + speed.ToString();
                distanceTravelled += speed * Time.deltaTime;
                transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
            }
           
        }

        private IEnumerator SpeedAdjust()
        {
            yield return new WaitForSeconds(0.3f);
            speed = baseSpeed + SpeedSetter.speedActual + speedAdjustment;
        }

        // If the path changes during the game, update the distance travelled so that the follower's position on the new path
        // is as close as possible to its position on the old path
        void OnPathChanged() {
            distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
        }
    }
}