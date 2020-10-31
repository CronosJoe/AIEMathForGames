using System;
using Raylib_cs;
using static Raylib_cs.Raylib;  // core methods (InitWindow, BeginDrawing())
using static Raylib_cs.Color;   // color (RAYWHITE, MAROON, etc.)
using static Raylib_cs.Raymath;
namespace VectorsTutorial
{
    public class SpriteObject : SceneObject
    {
        Texture2D texture = new Texture2D();
        //Image image = new Image();
        //getters and setters for height and width
        public float Width
        {
            get { return texture.width; }
        }
        public float Height
        {
            get { return texture.height; }
        }
        //constructor
        public SpriteObject()
        {
        }
        //load an image method
        public void Load(string filename)
        {
            Image img = LoadImage(filename);
            texture = LoadTextureFromImage(img);
        }
        //an ovverride for sceneobjects OnDraw method, this one draws the image.
        public override void OnDraw()
        {
            float rotation = (float)Math.Atan2(
           globalTransform.m2, globalTransform.m1);

            Raylib.DrawTextureEx(
            texture, new System.Numerics.Vector2(globalTransform.m7, globalTransform.m8),
            rotation * (float)(180.0f / Math.PI), 1, WHITE);
        }
    }
}
