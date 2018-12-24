-- This Source Code Form is subject to the terms of the bCDDL, v. 1.1.
-- If a copy of the bCDDL was not distributed with this
-- file, You can obtain one at http://beamng.com/bCDDL-1.1.txt
local M = {}
local steeringWheelLock = 0

local function onInit()
    electrics.values['4ws'] = 0
    steeringWheelLock = 0
    --get steeringWheelLock to correctly normalize steering value
    if hydros then
        for _, h in pairs (hydros.hydros) do
            --check if it's a steering hydro
            if h.inputSource == "steering_input" then
                steeringWheelLock = h.steeringWheelLock
            end
        end
    end
end

local function updateGFX(dt)
    if not electrics.values['steering'] or steeringWheelLock == 0 then
        return
    end
    local steer = electrics.values['steering']/steeringWheelLock --normalize
    local absSteer = math.abs(steer)

    local rws = (math.sin(absSteer * 1) * math.cos((absSteer * 3.3))) * 1.21
    rws = rws * fsign(steer) --Use the sign of the steering input to know the sign of rws output

    electrics.values['4ws'] = rws
end

-- public interface
M.onInit      = onInit
M.onReset     = onInit
M.updateGFX = updateGFX

return M