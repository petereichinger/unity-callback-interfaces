using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IAwake {
    void Awake();
}
public interface IFixedUpdate {
    void FixedUpdate();
}
public interface ILateUpdate {
    void LateUpdate();
}
public interface IOnAnimatorIK {
    void OnAnimatorIK(int layerIndex);
}
public interface IOnAnimatorMove {
    void OnAnimatorMove();
}
public interface IOnApplicationFocus {
    void OnApplicationFocus(bool hasFocus);
}
public interface IOnApplicationFocusCoroutine {
    IEnumerator OnApplicationFocus(bool hasFocus);
}
public interface IOnApplicationPause {
    void OnApplicationPause(bool pauseStatus);
}
public interface IOnApplicationPauseCoroutine {
    IEnumerator OnApplicationPause(bool pauseStatus);
}
public interface IOnApplicationQuit {
    void OnApplicationQuit();
}
public interface IOnAudioFilterRead {
    void OnAudioFilterRead(float[] data, int channels);
}
public interface IOnBecameInvisible {
    void OnBecameInvisible();
}
public interface IOnBecameInvisibleCoroutine {
    IEnumerator OnBecameInvisible();
}
public interface IOnBecameVisible {
    void OnBecameVisible();
}
public interface IOnBecameVisibleCoroutine {
    IEnumerator OnBecameVisible();
}
public interface IOnCollisionEnter {
    void OnCollisionEnter(Collision collision);
}
public interface IOnCollisionEnterCoroutine {
    IEnumerator OnCollisionEnter(Collision collision);
}
public interface IOnCollisionEnter2D {
    void OnCollisionEnter2D(Collision2D coll);
}
public interface IOnCollisionEnter2DCoroutine {
    IEnumerator OnCollisionEnter2D(Collision2D coll);
}
public interface IOnCollisionExit {
    void OnCollisionExit(Collision collisionInfo);
}
public interface IOnCollisionExitCoroutine {
    IEnumerator OnCollisionExit(Collision collisionInfo);
}
public interface IOnCollisionExit2D {
    void OnCollisionExit2D(Collision2D coll);
}
public interface IOnCollisionExit2DCoroutine {
    IEnumerator OnCollisionExit2D(Collision2D coll);
}
public interface IOnCollisionStay {
    void OnCollisionStay(Collision collisionInfo);
}
public interface IOnCollisionStayCoroutine {
    void OnCollisionStay(Collision collisionInfo);
}
public interface IOnCollisionStay2D {
    void OnCollisionStay2D(Collision2D coll);
}
public interface IOnCollisionStay2DCoroutine {
    IEnumerator OnCollisionStay2D(Collision2D coll);
}
public interface IOnConnectedToServer {
    void OnConnectedToServer();
}
public interface IOnControllerColliderHit {
    void OnControllerColliderHit(ControllerColliderHit hit);
}
public interface IOnDestroy {
    void OnDestroy();
}
public interface IOnDisable {
    void OnDisable();
}
public interface IOnDisconnectedFromServer {
    void OnDisconnectedFromServer(NetworkDisconnection info);
}
public interface IOnDrawGizmos {
    void OnDrawGizmos();
}
public interface IOnDrawGizmosSelected {
    void OnDrawGizmosSelected();
}
public interface IOnEnable {
    void OnEnable();
}
public interface IOnFailedToConnect {
    void OnFailedToConnect(NetworkConnectionError error);
}
public interface IOnFailedToConnectToMasterServer {
    void OnFailedToConnectToMasterServer(NetworkConnectionError info);
}
public interface IOnGUI {
    void OnGUI();
}
public interface IOnJointBreak {
    void OnJointBreak(float breakForce);
}
public interface IOnJointBreak2D {
    void OnJointBreak2D(Joint2D brokenJoint);
}
public interface IOnMasterServerEvent {
    void OnMasterServerEvent(MasterServerEvent msEvent);
}
public interface IOnMouseDown {
    void OnMouseDown();
}
public interface IOnMouseDrag {
    void OnMouseDrag();
}
public interface IOnMouseEnter {
    void OnMouseEnter();
}
public interface IOnMouseExit {
    void OnMouseExit();
}
public interface IOnMouseOver {
    void OnMouseOver();
}
public interface IOnMouseUp {
    void OnMouseUp();
}
public interface IOnMouseUpAsButton {
    void OnMouseUpAsButton();
}
public interface IOnNetworkInstantiate {
    void OnNetworkInstantiate(NetworkMessageInfo info);
}
public interface IOnParticleCollision {
    void OnParticleCollision(GameObject other);
}
public interface IOnParticleTrigger {
    void OnParticleTrigger();
}
public interface IOnPlayerConnected {
    void OnPlayerConnected(NetworkPlayer player);
}
public interface IOnPlayerDisconnected {
    void OnPlayerDisconnected(NetworkPlayer player);
}
public interface IOnPostRender {
    void OnPostRender();
}
public interface IOnPreCull {
    void OnPreCull();
}
public interface IOnPreRender {
    void OnPreRender();
}
public interface IOnRenderImage {
    void OnRenderImage(RenderTexture src, RenderTexture dest);
}
public interface IOnRenderObject {
    void OnRenderObject();
}
public interface IOnSerializeNetworkView {
    void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info);
}
public interface IOnServerInitialized {
    void OnServerInitialized();
}
public interface IOnTransformChildrenChanged {
    void OnTransformChildrenChanged();
}
public interface IOnTransformParentChanged {
    void OnTransformParentChanged();
}
public interface IOnTriggerEnter {
    void OnTriggerEnter(Collider other);
}
public interface IOnTriggerEnter2D {
    void OnTriggerEnter2D(Collider2D other);
}
public interface IOnTriggerExit {
    void OnTriggerExit(Collider other);
}
public interface IOnTriggerExit2D {
    void OnTriggerExit2D(Collider2D other);
}
public interface IOnTriggerStay {
    void OnTriggerStay(Collider other);
}
public interface IOnTriggerStay2D {
    void OnTriggerStay2D(Collider2D other);
}
public interface IOnTriggerEnterCoroutine {
    IEnumerator OnTriggerEnter(Collider other);
}
public interface IOnTriggerEnter2DCoroutine {
    IEnumerator OnTriggerEnter2D(Collider2D other);
}
public interface IOnTriggerExitCoroutine {
    IEnumerator OnTriggerExit(Collider other);
}
public interface IOnTriggerExit2DCoroutine {
    IEnumerator OnTriggerExit2D(Collider2D other);
}
public interface IOnTriggerStayCoroutine {
    IEnumerator OnTriggerStay(Collider other);
}
public interface IOnTriggerStay2DCoroutine {
    IEnumerator OnTriggerStay2D(Collider2D other);
}
public interface IOnValidate {
    void OnValidate();
}
public interface IOnWillRenderObject {
    void OnWillRenderObject();
}
public interface IReset {
    void Reset();
}
public interface IStart {
    void Start();
}
public interface IStartCoroutine {
    IEnumerator Start();
}
public interface IUpdate {
    void Update();
}