using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDependencyInjector
{
    // Start is called before the first frame update
    
    void GetScoreCoin();
    void AddScoreCoin(float coin,CoinModel coinModel);
    
}
