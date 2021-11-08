/// Original Code written and designed by Aeden C Graves.
///
///
/// CHANGE LOG:
///
/// DATE || msg: "" || Author Signature: SNG || version VERSION
///
/// 06/13/20 || msg: "Added Retro camera movement mode." || Author: Garrett Richards || version 20.6.8cp >> 20.6.13cu
/// 06/08/20 || msg: "Added ControllerPause function." || Author: Aedan Graves || version 20.6.2ff >> 20.6.8cp
/// 06/02/20 || msg: "Major fixes on slope detection. Fixed scaling issues. Fixed image grab errors." || Author: Aedan Graves || version 20.5.15b >> 20.6.2ff
/// 05/15/20 || msg: "Reinstated FOV kick controls under advanced movement settings." || Author: Aedan Graves || version 20.5.9b >> 20.5.15f
/// 05/14/20 || msg: "Fixed some slope detection bugs" || Author: Aedan Graves || version 20.5.9a >> 20.5.9b
/// 05/09/20 || msg: "Fixed slope/step detection registering triggers" || Author: Aedan Graves || version 20.4.22b >> 20.5.9a
/// 04/22/20 || msg: "Snap Rotation added to RotateCamera function. Added "Enable Audio/SFX" toggle and fixed static steps not working without headbobing enabled. || Aedan Graves || version 20.4.11qf >> 20.4.22b
/// 04/11/20 || msg: "Fixed controller slowly slipping down inclines." || Author: Aedan Graves || version 20.4.4qf >> 20.4.11qf
/// 04/04/20 || msg: "Fixed wall detection issues. Mouse Input Optimizations." || Author: Aedan Graves || version 20.3.26 >> 20.4.4qf
/// 26/03/20 || msg: "Fixed Stamina meter not draining. Fixed inconsistent jumping in Unity 2019.3+. Fixed Terrain not registering as ground. Added new Ground detection system using the capsule collider. Added RotateCamera Function" || Author Signature: Aedan Graves || version 20.3.8qf >> 20.3.26
/// 08/03/20 || msg: "Fixed draw stamina meter toggle throwing an error and disabling movement" || Author Signature: Aedan Graves || version 20.2.28cfu >> 20.3.8qf
/// 28/02/20 || msg: "ADDITIONS: 1) Added Mouse Inversion Options 2) Added Stair Detection (Experimental) UPDATES: 1) Removed InfiniGun compatibility features. 2) Converted Jump/Land movements to be intensity based. 3) Audio arrays now utilize Drag N' Drop. 4) Dynamic foot steps now are able to use more then one physic material as well as use normal materials (Experimental). FIXES 1) Fixed some variables not "Sticking" 2) Fixed phantom "_useFootStepSounds" flip-floping. 3) Fixed Jumping no longer working when scale is changed. 4) Fixed Slope Detection. 5) Fixed Crouch to properly move camera." || Author Signature: Aedan Graves || version: 19.9.21f >> 20.2.28cfu
/// 17/02/20 || msg: "Fixed input checking being done in FixedUpdate, causing inconsistent jumping and crouching." || Author Signature: Samuel Förström || version: 19.9.20f >> 19.9.21f 
/// 10/17/19 || msg: "Fixed inconsistent jumping/ground detection. Fixed headbobing axis amplification. Added toggle crouching." || Author Signature: Aedan Graves || version: 19.9.20f >> 19.10.17f 
/// 09/20/19 || msg: "Added support Email to the bottom of the inspector. Fixed issues with sticking to the walls. Removed the need for external assigning of a min and max friction material" || Author Signature: Aedan Graves || version: 19.9.13 >> 19.9.20f
/// 09/13/19 || msg: "New Editor script, Fixed Stamina, Fixed Crouching, Put 'FOV Kick' Under reconstruction, made dynamic foot steps easier to understand." || Author Signature: Aedan Graves || version: 19.7.28cu >> 19.9.13cu
/// 07/28/19 || msg: "Added function to effect mouse sensitivity based on the cameras FOV." || Author Signature: Aedan Graves || version: 19.6.7cu >> 19.7.28cu
/// 06/07/19 || msg: "Added ability to toggle the ability to jump from the editor." || Author Signature: Adam Worrell || 19.5.12feu >> version 19.6.7cu
/// 05/12/19 || msg: "Fixed non dynamic footsteping. Remade crouching system to be more efficient and added an input over ride. || Author Signature: Aedan Graves || version 19.3.22 cl >> 19.5.12feu
/// 03/22/19 || msg: "Cleaned up code" || Author Signature: Aedan Graves || version 19.3.19cu >> 19.3.22cl
/// 03/19/19 || msg: "Added a rudimentary slope detection system." || Author Signature: Aedan Graves || version 19.3.18a >> 19.3.19cu
/// 03/18/19 || msg: "Fixed Stamina" || Author Signature: Aedan Graves || version 19.3.11p >> 19.3.18a
/// 03/02/19 || msg: "Improved camera System" || Author Signature: Aedan Graves || version 19.3.2 >> 19.3.11p
/// 03/02/19 || msg: "Lowered maximum walk, sprint, and jump values" || Author Signature: Aedan Graves || version: 19.2.21 >> 19.3.2
/// 02/21/19 || msg: "Removed dynamic speed curve. Modified headbob logic || Author Signature: Aedan Graves || version: 19.2.15 >> 19.2.21
/// 02/15/19 || msg: "Added Camera shake. Made it possable to disable camera movement when jumping and landing." || Author Signature: Aedan Graves || version: 19.2.12 >> 19.2.15
/// 02/12/19 || msg: "Seperated Dynamic Footsteps from the Headbob calculations." || Author Signature: Aedan Graves || version: 1.6b >> 19.2.12
/// 02/08/19 || msg: "Added some more tooltips." || Author Signature: Aedan C Graves || version 1.6a >> 1.6b
/// 02/04/19 || msg: "Changed crouch function to use an In Editor defined input axis" || Author Signature: Aedan Graves || version 1.6 >> 1.6a
/// 12/13/18 || msg: "Added 'Custom' entry for Dynamic footstep system" || Author Signature: Aedan Graves || version 1.5b >> 1.6
/// 12/11/18 || msg: "Added Volume control to Footstep and Jump/land SFX." || Author Signature: Aedan Graves || version 1.5a >> 1.5b
/// 02/18/18 || msg: "Updated mouse rotation to allow pre-play rotation." || Author Signature: Aedan Graves || version 1.5 >> 1.5a
/// 01/31/18 || msg: "Changed Dynamic footstep system to use physics materials." || Author Signature: Aedan Graves || version 1.4c >> 1.5
/// 12/19/17 || msg: "Added headbob passthrough variables" || Author Signature: Aedan Graves || version 1.4b >> 1.4c
/// 12/02/17 || msg: "Made camera movement toggleable" || Author Signature: Aedan Graves || version 1.4a >> 1.4b
/// 10/16/17 || msg: "Made all sounds optional." || Author Signature: Aedan Graves || version 1.4 >> 1.4a
/// 10/09/17 || msg: "Added Optional FOV Kick" || Author Signature: Aedan Graves || version 1.3b >> 1.4
/// 10/08/17 || msg: "Improved Dynamic Footsteps." || Author Signature: Aedan Graves || version 1.3a >> 1.3b
/// 10/07/17 || msg: "BetaTesting Class" || Author Signature: Aedan Graves || version 1.3 >> 1.3a
/// 10/07/17 || msg: "Added Optional Dynamic Footsteps. Added optional Dynamic Speed Curve." || Author Signature: Aedan C Graves || version 1.2 >> 1.3
/// 10/03/17 || msg: "Added optional Crouch." || Author Signature: Aedan Graves || version v1.1 >> v1.2
/// 09/26/17 || msg: "Fixed Headbobbing in mid air. Added a option for head bobbing, Added optional Stamina. Added Auto Crosshair Feature." || Author Signature: Aedan Graves|| version v1.0 >> v1.1
/// 09/21/17 || msg: "Finished SMB FPS Logic." || Author Signature: Aedan Graves || version v0.0 >> v1.0
///
/// 
/// 
/// Made changes that you think should come "Out of the box"? E-mail the modified Script with A new entry on the top of the Change log to: modifiedassets@aedangraves.info

using UnityEngine;

[AddComponentMenu("First Person AIO"), RequireComponent(typeof(CapsuleCollider)), RequireComponent(typeof(Rigidbody))]
public class FirstPersonAIOBase
{
}