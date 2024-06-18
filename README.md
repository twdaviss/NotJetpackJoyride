<p align="center">
  <img width="400" height="300" src="https://github.com/twdaviss/NotJetpackJoyride/assets/89953361/30ea6b92-6f31-4f5a-b476-3e53cc333272">
</p>

### Contributors:
<div align="left">
  <table border="0" cellspacing="0" cellpadding="0">
    <tr>
      <td align="center" style="border: none;">
        <a href = "https://github.com/twdaviss"> <img src="https://github.com/NicholasOkovic/NotJetpackJoyride/assets/139954443/0ac794c1-d76e-4cc7-be9f-8a6e3dc693dc" alt="avatar1" width="50">
        <br><span>Twdaviss</span>
      </td>
      <td align="center" style="border: none;">
        <a href = "https://github.com/SleepingDragon0"> <img src="https://github.com/NicholasOkovic/NotJetpackJoyride/assets/139954443/c822852d-919a-49d6-b377-ee0781258936" alt="avatar2" width="50">
        <br><span>SleepingDragon0</span>
      </td>
      <td align="center" style="border: none;">
        <a href = "https://github.com/LeahTaurisano"> <img src="https://github.com/NicholasOkovic/NotJetpackJoyride/assets/139954443/742280df-39a0-47c9-8665-f5733e589e7f" alt="avatar3" width="50">
        <br><span>LeahTaurisano</span>
      </td>
      <td align="center" style="border: none;">
        <a href = "https://github.com/CultyMarble"> <img src="https://github.com/NicholasOkovic/NotJetpackJoyride/assets/139954443/7c19a2af-05cf-49fa-9c1e-d1d088b4a17c" alt="avatar4" width="50">
        <br><span>CultyMarble</span>
      </td>
      <td align="center" style="border: none;">
       <a href = "https://github.com/PhiBeo"> <img src="https://github.com/NicholasOkovic/NotJetpackJoyride/assets/139954443/859b874c-3a0c-44f5-9062-506bad1ea22e" alt="avatar5" width="50">
        <br><span>PhiBeo</span>
      </td>
      <td align="center" style="border: none;">
        <a href = "https://github.com/MiguelAyala25"> <img src="https://github.com/NicholasOkovic/NotJetpackJoyride/assets/139954443/3ddd6336-0f50-485b-8698-ac1541474f4a" alt="avatar6" width="50">
        <br><span>MiguelAyala25</span>
      </td>
      <td align="center" style="border: none;">
        <a href = "https://github.com/NicholasOkovic"> <img src="https://github.com/NicholasOkovic/NotJetpackJoyride/assets/139954443/f2c4675a-b38a-4551-8ac2-e0234ec5df36" alt="avatar7" width="50">
        <br><span>NicholasOkovic</span>
      </td>
    </tr>
  </table>
</div>

# Not Jetpack Joyride: 

A student project recreation of Jetpack Joyride
Made by the Spring class of VGP125 at LaSalle College Vancouver
Including features such as:
- Jetpack
- Jumping
- Lasers
- Rockets
- Zappers
- Scientists
- Coins
- Leaderboard

## How To Play:
**Desktop:** Press Spacebar to Jump

**Mobile:** Tap Screen to Jump

***That's it!***

## My Role:
**Gameplay Programmer**
## My Contributions:
### :rocket: Player Controls + Animation :rocket: 
I designed and coded the player controls for the game. This included the jetpack thrust that propels the player upwards, as well as a jump where players can gain height quickly from the ground.

![Jetpack](https://github.com/twdaviss/NotJetpackJoyride/assets/89953361/50e82e03-20ec-44ec-a36f-0b57ce687dfa)

I also designed the player animator within Unity's animation system, using sprites from another team member.

### :rocket: Jetpack Effects :rocket: 
   Like in the original, our character's jetpack is actually a minigun shooting bullets at the ground. To sell this idea we included bullet and shell particles that shoot out of the character towards the ground and trailing behind, respectively. The bullet particles also spawn fragment particles when they hit the ground.
   
![JetpackEffects](https://github.com/twdaviss/NotJetpackJoyride/assets/89953361/4b5ca4aa-4aa2-4d6e-8e1d-1a963d398b1f)

### :rocket: Death Animation :rocket: 
   When the player dies they fall to the ground and bounce a few times as they slow down before the leaderboard appears. The character sprite changes depending on whether they are touching the ground or not.

<img width="300" height="300" src="https://github.com/twdaviss/NotJetpackJoyride/assets/89953361/3b0b128c-6658-4fdc-9d1a-0ac17e0c812d">

### :rocket: Wallpaper + Obstacle Scrolling :rocket: 
   I designed the original background scrolling system which was expanded upon by another team member. The scrolling background and obstacles give the illusion that the player is moving, and the player's speed is derived from the speed of the background. In addition to this, I designed a simple system to control the speed of both the wallpaper scrolling and obstacles to make sure that they are consistent. When the player dies, the background slows down gradually to a stop as the player stops bouncing.
### :rocket: Rocket Obstacles + Effects
   I designed the rocket obstacles that fly across the screen. The rockets can be spawned in 3 different varieties: **Static, Targeted**, and **Tracking**.
   - **Static Rockets** spawn at preset heights and do not depend on the players position.
     
   - **Targeted Rockets** spawn at the players current height, but do not deviate from that height.
     
   - **Tracking Rockets** will adjust to the players height until just before appearing on screen.
   There is a visual indicator that appears on screen to warn the player of an incoming rocket as well as from which height. I designed the mechanics as well as a trailing fire and smoke particle effect that follows it.

![Rockets2](https://github.com/twdaviss/NotJetpackJoyride/assets/89953361/d8b13638-9b7f-4195-86c5-660eb9462926)

### :rocket: Pause Menu :rocket: 
  I designed the Pause Menu with a pause button on screen, and a simple UI panel with buttons for Continue, Restart, and Main Menu

<img width="200" height="200" src="https://github.com/twdaviss/NotJetpackJoyride/assets/89953361/b5dc3fcd-766d-47fc-afc7-b05cef946db0">

## :rocket: Challenges: :rocket: 

The biggest challenges for me with this project were mostly with Unity's particle system. I hadn't used it previously and there were a few limitations/ quirks with the system that made it difficult to get the desired effect. 

- The particles would originally move about in 3D space even when in the 2D mode which caused some issues. 
- A major challenge that I was unable to overcome was making the bullets ricochet off the ground. The ricochet itself was not a problem, but I was unable to have the sprite face in the new direction after hitting the ground. We settled for the fragment effects, which look better anyway.
