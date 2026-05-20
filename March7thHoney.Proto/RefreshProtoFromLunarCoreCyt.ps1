param(
    [string]$SourceProtoDir = "D:\Projects\LunarCore-Cyt\proto"
)

$ErrorActionPreference = "Stop"

if (-not (Test-Path $SourceProtoDir)) {
    throw "Source proto directory not found: $SourceProtoDir"
}

$protoFileDir = Join-Path $PSScriptRoot "ProtoFile"
New-Item -ItemType Directory -Force -Path $protoFileDir | Out-Null

Copy-Item -Path (Join-Path $SourceProtoDir "*.proto") -Destination $protoFileDir -Force

$targetNs = 'option csharp_namespace = "March7thHoney.Proto";'
Get-ChildItem $protoFileDir -File -Filter *.proto | ForEach-Object {
    $path = $_.FullName
    $raw = Get-Content -LiteralPath $path -Raw
    if ($raw -notmatch 'option\s+csharp_namespace\s*=') {
        $lines = Get-Content -LiteralPath $path
        if ($lines.Count -ge 1 -and $lines[0] -match '^syntax\s*=') {
            $new = @($lines[0], '', $targetNs) + $lines[1..($lines.Count - 1)]
            Set-Content -LiteralPath $path -Value $new -Encoding utf8
        } else {
            Set-Content -LiteralPath $path -Value ($targetNs + "`r`n" + $raw) -Encoding utf8
        }
    }
}

Get-ChildItem $PSScriptRoot -File -Filter *.cs | Remove-Item -Force

Push-Location $protoFileDir
try {
    Get-ChildItem -File -Filter *.proto | ForEach-Object {
        protoc --proto_path=. --csharp_out=.. $_.Name
        if ($LASTEXITCODE -ne 0) {
            throw "protoc failed: $($_.Name)"
        }
    }
} finally {
    Pop-Location
}
