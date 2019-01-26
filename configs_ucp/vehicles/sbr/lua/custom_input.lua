-- This Source Code Form is subject to the terms of the bCDDL, v. 1.1.
-- If a copy of the bCDDL was not distributed with this
-- file, You can obtain one at http://beamng.com/bCDDL-1.1.txt

local M = {}

local function onReset()
  electrics.values['lifter_FL'] = 0
  electrics.values['lifter_FL_input'] = 0
  electrics.values['lifter_FR'] = 0
  electrics.values['lifter_FR_input'] = 0
  electrics.values['lifter_RL'] = 0
  electrics.values['lifter_RL_input'] = 0
  electrics.values['lifter_RR'] = 0
  electrics.values['lifter_RR_input'] = 0
end

local function updateGFX(dt) -- ms
  electrics.values['lifter_FL'] = math.min(1, math.max(-0.0, (electrics.values['lifter_FL'] + electrics.values['lifter_FL_input'] * dt * 99.9)))
  electrics.values['lifter_FR'] = math.min(1, math.max(-0.0, (electrics.values['lifter_FR'] + electrics.values['lifter_FR_input'] * dt * 99.9)))
  electrics.values['lifter_RL'] = math.min(1, math.max(-0.0, (electrics.values['lifter_RL'] + electrics.values['lifter_RL_input'] * dt * 99.9)))
  electrics.values['lifter_RR'] = math.min(1, math.max(-0.0, (electrics.values['lifter_RR'] + electrics.values['lifter_RR_input'] * dt * 99.9)))
end

local function liftBarrel(part, value)
  if part == "FL" then electrics.values.lifter_FL_input = value end
  if part == "FR" then electrics.values.lifter_FR_input = value end
  if part == "RL" then electrics.values.lifter_RL_input = value end
  if part == "RR" then electrics.values.lifter_RR_input = value end
end

-- public interface
M.onInit    = onReset
M.onReset   = onReset
M.updateGFX = updateGFX
M.liftBarrel = liftBarrel

return M
