using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GV_LAB_4
{
    public partial class Form1 : Form
    {
        Scene scene;
        Canvas canvas;
        static GravityInfluencer influencer;
        float deltaTime;
        DateTime lastTickTime;

        TextBox txtGravity;
        TextBox txtXVelocity;
        TextBox txtYVelocity;
        TextBox txtXPosition;
        TextBox txtYPosition;

        float lastGravityValue = 0;
        float xVelocity = 0;
        float yVelocity = 0;
        float newXVelocity = 0;
        float newYVelocity = 0;
        float xPosition = 0;
        float yPosition = 0;
        float newXPosition = 0;
        float newYPosition = 0;

        bool updateVelocity = false;

        Random random = new Random();

        private bool setsDeleted = false;

        public Form1()
        {
            InitializeComponent();
            Init();
            InitializeGravityControl();
        }

        public void Init()
        {
            if (PCT_CANVAS.Width == 0)
                return;
            deltaTime = 0;
            scene = new Scene();
            canvas = new Canvas(PCT_CANVAS.Size);

            PCT_CANVAS.Image = canvas.bitmap;
        }

        private void InitializeGravityControl()
        {
            txtGravity = gravtxt;
            txtXVelocity = xValtxt;
            txtYVelocity = yValtxt;
            txtXPosition = xPostxt;
            txtYPosition = yPostxt;
            this.Controls.Add(txtGravity);
            this.Controls.Add(txtXVelocity);
            this.Controls.Add(txtYVelocity);
            this.Controls.Add(txtXPosition);
            this.Controls.Add(txtYPosition);

            txtGravity.TextChanged += TxtGravity_TextChanged;
            txtXVelocity.TextChanged += TxtXVelocity_TextChanged;
            txtYVelocity.TextChanged += TxtYVelocity_TextChanged;
            txtXPosition.TextChanged += TxtXPosition_TextChanged;
            txtYPosition.TextChanged += TxtYPosition_TextChanged;
        }

        private void TxtGravity_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtGravity.Text, out lastGravityValue))
            {
                lastGravityValue = 0;
            }
        }

        private void TxtXVelocity_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtXVelocity.Text, out newXVelocity))
            {
                newXVelocity = 0;
            }
        }

        private void TxtYVelocity_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtYVelocity.Text, out newYVelocity))
            {
                newYVelocity = 0;
            }
        }

        private void TxtXPosition_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtXPosition.Text, out newXPosition))
            {
                newXPosition = 0;
            }
        }

        private void TxtYPosition_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtYPosition.Text, out newYPosition))
            {
                newYPosition = 0;
            }
        }

        private void BTN_ADD_EMITTER_Click(object sender, EventArgs e)
        {
            // If sets have been deleted, clear the scene before adding a new emitter
            if (setsDeleted)
            {
                scene.Emitter.Clear();
                setsDeleted = false; // Reset the flag
            }

            float randomGravityValue = (float)(random.NextDouble() * 9.8);
            xVelocity = (float)(random.NextDouble() * 2);
            yVelocity = (float)(random.NextDouble() * 2);
            xPosition = (float)(random.NextDouble() * PCT_CANVAS.Width);
            yPosition = (float)(random.NextDouble() * PCT_CANVAS.Height);

            influencer = new GravityInfluencer(randomGravityValue, PCT_CANVAS.Height);

            Emitter emitter = new Emitter(new PointF(xPosition, yPosition), PCT_CANVAS.Size);
            emitter.Influencers.Add(influencer);
            scene.Emitter.Add(emitter);

            lastGravityValue = randomGravityValue;

            txtGravity.Text = lastGravityValue.ToString("0.00");
            txtXVelocity.Text = xVelocity.ToString("0.00");
            txtYVelocity.Text = yVelocity.ToString("0.00");
            txtXPosition.Text = xPosition.ToString("0.00");
            txtYPosition.Text = yPosition.ToString("0.00");

            TIMER.Start();
        }

        private void BTN_UPDATE_GRAVITY_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtGravity.Text, out float newGravityValue))
            {
                influencer.GravitationalConstant = newGravityValue;
            }

            if (float.TryParse(txtXVelocity.Text, out float newVelocityX))
            {
                xVelocity = newVelocityX;
            }

            if (float.TryParse(txtYVelocity.Text, out float newVelocityY))
            {
                yVelocity = newVelocityY;
            }

            if (float.TryParse(txtXPosition.Text, out float newPositionX))
            {
                xPosition = newPositionX;
            }

            if (float.TryParse(txtYPosition.Text, out float newPositionY))
            {
                yPosition = newPositionY;
            }
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan elapsed = currentTime - lastTickTime;
            lastTickTime = currentTime;
            deltaTime = (float)elapsed.TotalSeconds;

            foreach (var emitter in scene.Emitter)
            {
                int particlesToEmit = 10;
                float minVelocity = -5; // Adjust as needed
                float maxVelocity = 5; // Adjust as needed

                for (int i = 0; i < particlesToEmit; i++)
                {
                    emitter.EmitParticle(emitter.Position, new Size(), minVelocity, maxVelocity);
                }
            }

            if (scene.Emitter.Count > 0)
            {
                scene.Emitter[scene.Emitter.Count - 1].Position = new PointF(xPosition, yPosition);
            }

            canvas.Render(scene, deltaTime);
            PCT_CANVAS.Invalidate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float windStrength = 5; // Adjust the wind strength as needed

            // Add wind influencer to each emitter
            foreach (var emitter in scene.Emitter)
            {
                emitter.AddWindInfluencer(windStrength);
            }

            // Render the scene
            canvas.Render(scene, deltaTime);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Assuming you have a Scene object named scene
            PointF darkHoleCenter = new PointF(400, 300); // Adjust the position of the dark hole as needed
            float attractionStrength = 0.1f; // Adjust the attraction strength as needed

            // Remove any existing influencers (such as wind or gravity) from each emitter
            foreach (var emitter in scene.Emitter)
            {
                emitter.Influencers.Clear();
            }

            // Add dark hole influencer to each emitter
            foreach (var emitter in scene.Emitter)
            {
                emitter.Influencers.Add(new DarkHoleInfluencer(darkHoleCenter, attractionStrength));
            }

            // Render the scene
            canvas.Render(scene, deltaTime);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TIMER.Stop();
            foreach (var emitter in scene.Emitter)
            {
                emitter.Particles.Clear();
            }

            // Clear the scene of all existing emitters when sets are deleted
            scene.Emitter.Clear();
            setsDeleted = true; // Set the flag to true indicating sets have been deleted

            // Render the scene after deleting the sets
            canvas.Render(scene, deltaTime);
            PCT_CANVAS.Invalidate();
        }
    }
}
