﻿using System;
using System.Diagnostics;
using Raylib_cs;
using static Raylib_cs.Raylib;  // core methods (InitWindow, BeginDrawing())
using static Raylib_cs.Color;   // color (RAYWHITE, MAROON, etc.)
using static Raylib_cs.Raymath;
namespace VectorsTutorial
{
    class Game
    {
        Stopwatch stopwatch = new Stopwatch();
        private long currentTime = 0;
        private long lastTime = 0;
        private float timer = 0;
        private int fps = 1;
        private int frames;
        private float deltaTime = 0.005f;

        public SceneObject tankObject = new SceneObject();
        public SceneObject turretObject = new SceneObject();
        public SpriteObject tankSprite = new SpriteObject();
        public SpriteObject turretSprite = new SpriteObject();
        public SceneObject bulletObject = new SceneObject();
        public SpriteObject bulletSprite = new SpriteObject();
        public bool fired = false;
        public void Init()
        {
            stopwatch.Start();
            lastTime = stopwatch.ElapsedMilliseconds;
            fired = false;
            #region init
            tankSprite.Load("tankBlue_outline.png");
            // sprite is facing the wrong way... fix that here
            tankSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            // sets an offset for the base, so it rotates around the centre
            tankSprite.SetPosition(-tankSprite.Width / 2.0f, tankSprite.Height /
           2.0f);

            turretSprite.Load("barrelBlue.png");
            turretSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            // set the turret offset from the tank base
            turretSprite.SetPosition(0, turretSprite.Width / 2.0f);

            bulletSprite.Load("bulletBlueSilver_outline.png");
            bulletSprite.SetRotate(-180 * (float)(Math.PI / 180.0f));
            //should set its offset to be the same as the turrets
            bulletSprite.SetPosition(0, turretSprite.Width / 2.0f);
            // set up the scene object hierarchy - parent the turret to the base,
            // then the base to the tank sceneObject
            bulletObject.AddChild(bulletSprite);
            turretObject.AddChild(turretSprite);
            tankObject.AddChild(tankSprite);
            tankObject.AddChild(turretObject);
            tankObject.SetPosition(GetScreenWidth() / 2.0f, GetScreenHeight() / 2.0f);
            #endregion

        }
        public void Shutdown()
        { }
        public void Update()
        {
            currentTime = stopwatch.ElapsedMilliseconds;
            deltaTime = (currentTime - lastTime) / 1000.0f;
            timer += deltaTime;
            if (timer >= 1)
            {
                fps = frames;
                frames = 0;
                timer -= 1;
            }
            frames++;
            #region move
            if (IsKeyDown(KeyboardKey.KEY_A) && !fired)
            {
                tankObject.Rotate(-deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_D) && !fired)
            {
                tankObject.Rotate(deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_W) && !fired)
            {
                Vector3 facing = new Vector3(
               tankObject.LocalTransform.m1,
               tankObject.LocalTransform.m2, 1) * deltaTime * 100;
                tankObject.Translate(facing.x, facing.y);
            }
            if (IsKeyDown(KeyboardKey.KEY_S) && !fired)
            {
                Vector3 facing = new Vector3(
               tankObject.LocalTransform.m1,
               tankObject.LocalTransform.m2, 1) * deltaTime * -100;
                tankObject.Translate(facing.x, facing.y);
            }
            if (IsKeyDown(KeyboardKey.KEY_Q) && !fired)
            {
                turretObject.Rotate(-deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_E) && !fired)
            {
                turretObject.Rotate(deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_SPACE)&& !fired)
            {
                fired = true;
                turretSprite.AddChild(bulletObject);
                bulletObject.UpdateTransform();
                
                
            }
            if (fired)
            {
                Vector3 facing = new Vector3(
               bulletObject.LocalTransform.m1,
               bulletObject.LocalTransform.m2, 1) * deltaTime * 100;
                bulletObject.Translate(facing.x, facing.y);
            }
            #endregion
            tankObject.Update(deltaTime);
            lastTime = currentTime;
        }
        public void Draw()
        {
            BeginDrawing();
            ClearBackground(WHITE);
            DrawText(fps.ToString(), 10, 10, 12, RED);
            tankObject.Draw();
            if (fired)
            {
                bulletObject.Draw();
            }
            EndDrawing();
        }
    }
}
