
boolean clickedOnce = false;
boolean clickedTwice = false;
float x1, y1, x2, y2;

PVector circlePos = new PVector(0,0);
PVector dir = new PVector(0,0);
PVector movDir = new PVector(0,0);

void draw()
{
  background (255);
  if(clickedTwice)
  {
    line(x1,y1,x2,y2);
  }
  
  
  circle(circlePos.x,circlePos.y, 20);
  circleFollow();
  
}


void mouseClicked()
{
  if(clickedOnce == false)
  {
      x1 = mouseX;
      y1 = mouseY;
      clickedOnce = true;
  }
  else
  {
     x2 = mouseX;
     y2 = mouseY;
     clickedTwice = true;
     
     
     // new direction for circle
     dir.x = mouseX - circlePos.x;
     dir.y = mouseY - circlePos.y;
     
     // random speed
     float vel = random(10);
     
     movDir = dir.normalize();
     movDir.x *=vel;
     movDir.y *=vel;
     
     
     
  }
  
}




void circleFollow()
{
  if(clickedTwice)
  {
    circlePos.x += movDir.x;
    circlePos.y += movDir.y;
    
  }
}
