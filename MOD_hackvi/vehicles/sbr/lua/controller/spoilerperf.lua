-- This Source Code Form is subject to the terms of the bCDDL, v. 1.1.
-- If a copy of the bCDDL was not distributed with this
-- file, You can obtain one at http://beamng.com/bCDDL-1.1.txt

local M = {}
M.type = "auxilliary"
M.relevantDevice = nil

local speedThresholdNormalPosition = 23
local speedThresholdClosedPosition = 1 -- 12 (Que se baje al reducir la velocidad)
local speedThresholdBrakingPosition = 1 --8 (Que baje mientras frena y baja de velocidad?)
local brakeThresholdBrakingPosition = 0.5

local spoilerClosed = 0
local spoilerNormal = 0.73
local spoilerBraking = 1

local function init()
    electrics.values.spoiler = 0
end

local function updateGFX(dt)
    local spoiler = electrics.values.spoiler
    local speed = electrics.values.wheelspeed

    if electrics.values.brake > brakeThresholdBrakingPosition then --check for brake input
        spoiler = speed >= speedThresholdBrakingPosition and spoilerBraking or spoilerClosed
    elseif speed >= speedThresholdNormalPosition then --we are not braking, check for normal spoiler mode speed
        spoiler = spoilerNormal --(we are above the normal spoiler position speed, so set the spoiler to normal)
    else --we are not braking AND below the normal position speed
        spoiler = (spoiler == spoilerNormal and speed >= speedThresholdClosedPosition) and spoilerNormal or spoilerClosed
    end

    electrics.values.spoiler = spoiler
end

M.init = init
M.updateGFX = updateGFX

return M