-- Additional lights made by AR162b for BeamNG.Drive

local M = {}

local blinkPDTimerThreshold = 0.4
local blinkPDTimerThresholdHalf = 0.0
local blinkPDTimer = 0
local blinkPDTimerMode = 0
local blinkPDTimer = 0
local blinkPDPulseLeft = 0
local blinkPDPulseRight = 1
local blinkPDModeA = 0
local blinkPDModeB = 1
local spinning = 0


local function onInit()

	electrics.values['PD_R'] = 0
	electrics.values['PD_L'] = 0

	electrics.values['spinright'] = 0
	electrics.values['spinleft'] = 0

end

local function reset()
	onInit()
end

local function generateBlinkPDTimer(dt)

    blinkPDTimerThresholdHalf = (blinkPDTimerThreshold / 2) * electrics.values['lightbar'] 

    blinkPDTimer = blinkPDTimer + (dt)

    if blinkPDTimer > blinkPDTimerThreshold then
        blinkPDTimer = blinkPDTimer - blinkPDTimerThreshold
	blinkPDPulseLeft = 0
	blinkPDPulseRight = 1
	else
    if blinkPDTimer > blinkPDTimerThresholdHalf then
	blinkPDPulseLeft = 1
	blinkPDPulseRight = 0
	end
    end
end

local function generateBlinkPDTimerMode(dt)

    blinkPDTimerMode = (blinkPDTimerMode + (dt)) * electrics.values['lightbar'] 

    if blinkPDTimerMode > 7 then
        blinkPDTimerMode = blinkPDTimerMode - 7
	blinkPDModeA = 0
	blinkPDModeB = 1
	else
    if blinkPDTimerMode > 5 then
	blinkPDModeA = 1
	blinkPDModeB = 0
	end
    end
end


local function generateSpinning(dt)

    		if spinning > 359 then
        		spinning = 0
		else
			spinning = spinning + (((dt * 100) % 360) * electrics.values['lightbar'])
		end
    	
end

local function updateGFX(dt)
	
    local vals = M.values
    generateBlinkPDTimer(dt)	
    generateBlinkPDTimerMode(dt)
    generateSpinning(dt)

    	electrics.values['PD_R'] = (electrics.values['lightbar']  * ((blinkPDPulseRight * blinkPDModeB) + (blinkPDPulseLeft * blinkPDModeA)))
    	electrics.values['PD_L'] = (electrics.values['lightbar']  * blinkPDPulseLeft)
	electrics.values['spinright'] = (spinning)
    	electrics.values['spinleft'] = (360 - spinning)


end

 


-- public interface
M.Reset       = Reset
M.onInit	= onInit
M.updateGFX   = updateGFX

return M