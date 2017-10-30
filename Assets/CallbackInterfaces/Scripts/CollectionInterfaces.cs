using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CallbackInterfaces.Collections {
    public interface IStandardLifecycle : IAwake, IStart, IUpdate, IOnDestroy{
        
    }

    public interface ICollidable : IOnCollisionEnter, IOnCollisionStay, IOnCollisionExit {
        
    }

    public interface ICollidable2D : IOnCollisionEnter2D, IOnCollisionStay2D, IOnCollisionExit2D {
        
    }
}