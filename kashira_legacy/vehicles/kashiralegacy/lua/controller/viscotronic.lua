-- This Source Code Form is subject to the terms of the bCDDL, v. 1.1.
-- If a copy of the bCDDL was not distributed with this
-- file, You can obtain one at http://beamng.com/bCDDL-1.1.txt

local M = {}
M.type = "auxilliary"
M.relevantDevice = "transfercase"

local transfercase = nil
local origViscousCoef = 0

local function updateGFX()
  if not transfercase then return end
  if (transfercase.outputAV1 > (transfercase.inputAV + 1) and drivetrain.gear >= 0) or input.parkingbrake > 0.5 then
    transfercase.viscousCoef = 0
  else
    transfercase.viscousCoef = origViscousCoef
  end
end

local function init(jbeamData)
  transfercase = powertrain.getDevice(jbeamData.transfercaseName)
  if transfercase then
    origViscousCoef = transfercase.viscousCoef
  end
end

M.init = init
M.updateGFX = updateGFX

return M