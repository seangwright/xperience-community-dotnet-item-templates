# From https://github.com/sayedihashimi/template-sample#how-to-test-template-changes-locally
function Reset-Templates{
    [cmdletbinding()]
    param(
        [string]$templateEngineUserDir = (join-path -Path $env:USERPROFILE -ChildPath .templateengine)
    )
    begin {
        Write-Host "Clearing template cache at $templateEngineUserDir"
    }
    process{
        'resetting dotnet new templates. folder: "{0}"' -f $templateEngineUserDir | Write-host
        get-childitem -path $templateEngineUserDir -directory | Select-Object -ExpandProperty FullName | remove-item -recurse -force
        &dotnet new --debug:reinit
    }
    end {
        Write-Host "Template cache cleared"
    }
}

Reset-Templates