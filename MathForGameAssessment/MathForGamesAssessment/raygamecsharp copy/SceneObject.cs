using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace VectorsTutorial
{
    public class SceneObject
    {
        protected SceneObject parent = null;
        protected List<SceneObject> children = new List<SceneObject>();

        protected Matrix3 localTransform = new Matrix3();
        protected Matrix3 globalTransform = new Matrix3();
        //a get for the protected parent variable
        SceneObject Parent
        {
            get { return parent; }
        }
        //a generic constructor
        public SceneObject()
        {
        }
        //local transform variable get
        public Matrix3 LocalTransform
        {
            get { return localTransform; }
        }
        //global transform variable get
        public Matrix3 GlobalTransform
        {
            get { return globalTransform; }
        }
        //updates the transforms by checking if the parent of current object exists or not, if the parent exists it sets transform to the parents gT * lT
        public void UpdateTransform()
        {
            if (parent != null)
            {
                globalTransform = parent.globalTransform * localTransform;
            }
            else
            {
                globalTransform = localTransform;
            }
            foreach (SceneObject child in children)
                child.UpdateTransform();
        }
        //returns the amount of childed objects
        public int GetChildCount()
        {
            return children.Count;
        }
        //returns a child object if you imput an index.
        public SceneObject GetChild(int index)
        {
            return children[index];
        }
        //adds a child to the array
        public void AddChild(SceneObject child)
        {
            // make sure it doesn't have a parent already
            Debug.Assert(child.parent == null);
            // assign "this as parent
            child.parent = this;
            // add new child to collection
            children.Add(child);
        }
        //removes a childed object from the array
        public void RemoveChild(SceneObject child)
        {
            if (children.Remove(child) == true)
            {
                child.parent = null;
            }
        }
        ~SceneObject()
        {
            if (parent != null)
            {
                parent.RemoveChild(this);
            }
            foreach (SceneObject so in children)
            {
                so.parent = null;
            }
        }
        //a virtual method for the OnUpdate
        public virtual void OnUpdate(float deltaTime)
        {
        }
        //a virtual method for the OnDraw
        public virtual void OnDraw()
        {
        }
        //An update method to update my variables based on deltaTime
        public void Update(float deltaTime)
        {
            // run OnUpdate behaviour
            OnUpdate(deltaTime);
            // update children
            foreach (SceneObject child in children)
            {
                child.Update(deltaTime);
            }
        }
        //a draw method for drawing our images.
        public void Draw()
        {
            // run OnDraw behaviour
            OnDraw();
            // draw children
            foreach (SceneObject child in children)
            {
                child.Draw();
            }
        }
        //Sets the position of the transform matrix
        public void SetPosition(float x, float y)
        {
            localTransform.SetTranslation(x, y);
            UpdateTransform();
        }
        //Rotates the matrix transform on the z axis
        public void SetRotate(float radians)
        {
            localTransform.SetRotateZ(radians);
            UpdateTransform();
        }
        //scales the local transform of an object
        public void SetScale(float width, float height)
        {
            localTransform.SetScaled(width, height, 1);
            UpdateTransform();
        }// translates the position of the object
        public void Translate(float x, float y)
        {
            localTransform.Translate(x, y);
            UpdateTransform();
        }
        //rotates the object on the z axis
        public void Rotate(float radians)
        {
            localTransform.RotateZ(radians);
            UpdateTransform();
        }
        //scales the object
        public void Scale(float width, float height)
        {
            localTransform.Scale(width, height, 1);
            UpdateTransform();
        }

    }
}
