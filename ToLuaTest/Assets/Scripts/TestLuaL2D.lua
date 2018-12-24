-- start
local Live2D = live2d.Live2D;
local Live2DModelUnity = live2d.Live2DModelUnity;
local live2DModel;

function start()                 
    Live2D.init();
    local filePath = UnityEngine.Application.dataPath.."\\Resources/1xinchang/model/1jiazou/zhitianxinchang_jiazhou.moc.bytes";
    print("filePath: "..filePath);

    local file = io.open(filePath, "r");
    local str = file:read("*a");
    print(str);
    -- 关闭打开的文件
    file:close()


    -- local fs = FileStream(filePath, FileMode.Open, FileAccess.Read);
 --    local buffur = {};
 --    fs.Read(buffur, 0, fs.Length);
 --    fs.Close();

    local buffer = System.IO.File.ReadAllBytes(filePath);
    live2DModel = Live2DModelUnity.loadModel(buffer);

    for i=0,2 do
        local texture = UnityEngine.Resources.Load("1xinchang/model/1jiazou/zhitianxinchang_jiazhou.2048/texture_0"..i);
        live2DModel:setTexture(i, texture);
    end

    local modelWidth = live2DModel:getCanvasWidth();
    print("modelWidth:"..modelWidth);
    -- local m1 = UnityEngine.Matrix4x4.Ortho(0, modelWidth, modelWidth, 0, -50, 50);
    -- local m2 = UnityEngine.Transform.get_localToWorldMatrix;
    -- local m3 = m2 * m1;
    local m3 = {
        1,0,0,0,
        0,1,0,0,
        0,0,1,0,
        0,0,0,0,
    };
    live2DModel:setMatrix(m3);
end

-- update
function update()
    -- if (motionMgr.isFinished() == true)
    --     motionMgr.startMotion(motion);
    -- motionMgr.updateParam(live2DModel);
    do return end;
    live2DModel:update();
end

-- onRenderObject
function onRenderObject()
    do return end;
    live2DModel:draw();
end

-- using System.Collections;
-- using System.Collections.Generic;
-- using UnityEngine;
-- using live2d;

-- public class TestL2D : LuaClient {
--     private Live2DModelUnity live2DModel;
--     private Live2DMotion motion;
--     private MotionQueueManager motionMgr;

--     // Use this for initialization
--     void Start () {
--         Live2D.init();

--         string filePath = UnityEngine.Application.dataPath + "\\Resources/1xinchang/model/1jiazou/zhitianxinchang_jiazhou.moc.bytes";
--         Debug.Log("filePath: " + filePath);
--         live2DModel = Live2DModelUnity.loadModel(filePath);

--         for (int i = 0; i < 3; i++)
--         {   
--             Texture2D texture = Resources.Load<Texture2D>("1xinchang/model/1jiazou/zhitianxinchang_jiazhou.2048/texture_0" + i);
--             live2DModel.setTexture(i, texture);
--         }

--         motion = Live2DMotion.loadMotion(UnityEngine.Application.dataPath + "\\Resources/1xinchang/motions/ztxc_1_shenshou.mtn");
--         motionMgr = new MotionQueueManager();
--     }
    
--     // Update is called once per frame
--     void Update () {
--         float modelWidth = live2DModel.getCanvasWidth();
--         Matrix4x4 m1 = Matrix4x4.Ortho(
--                 0, modelWidth, modelWidth,
--                 0, -50.0f, 50.0f);
--         Matrix4x4 m2 = transform.localToWorldMatrix;
--         Matrix4x4 m3 = m2 * m1;

--         live2DModel.setMatrix(m3);

--         if (motionMgr.isFinished() == true)
--             motionMgr.startMotion(motion);
--         motionMgr.updateParam(live2DModel);
--         live2DModel.update();
--     }

--     void OnRenderObject()
--     {
--         live2DModel.draw();
--     }
-- }
