using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JHKBPIEOLFB : IMessage<JHKBPIEOLFB>, IMessage, IEquatable<JHKBPIEOLFB>, IDeepCloneable<JHKBPIEOLFB>, IBufferMessage
{
	private static readonly MessageParser<JHKBPIEOLFB> _parser = new MessageParser<JHKBPIEOLFB>(() => new JHKBPIEOLFB());

	private UnknownFieldSet _unknownFields;

	public const int HNFDGOMEIFMFieldNumber = 1;

	private uint hNFDGOMEIFM_;

	public const int IPBIOPFGBOMFieldNumber = 8;

	private uint iPBIOPFGBOM_;

	public const int DCPKPNLKGMMFieldNumber = 13;

	private uint dCPKPNLKGMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JHKBPIEOLFB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JHKBPIEOLFBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HNFDGOMEIFM
	{
		get
		{
			return hNFDGOMEIFM_;
		}
		set
		{
			hNFDGOMEIFM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPBIOPFGBOM
	{
		get
		{
			return iPBIOPFGBOM_;
		}
		set
		{
			iPBIOPFGBOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCPKPNLKGMM
	{
		get
		{
			return dCPKPNLKGMM_;
		}
		set
		{
			dCPKPNLKGMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHKBPIEOLFB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHKBPIEOLFB(JHKBPIEOLFB other)
		: this()
	{
		hNFDGOMEIFM_ = other.hNFDGOMEIFM_;
		iPBIOPFGBOM_ = other.iPBIOPFGBOM_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHKBPIEOLFB Clone()
	{
		return new JHKBPIEOLFB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JHKBPIEOLFB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JHKBPIEOLFB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HNFDGOMEIFM != other.HNFDGOMEIFM)
		{
			return false;
		}
		if (IPBIOPFGBOM != other.IPBIOPFGBOM)
		{
			return false;
		}
		if (DCPKPNLKGMM != other.DCPKPNLKGMM)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (HNFDGOMEIFM != 0)
		{
			num ^= HNFDGOMEIFM.GetHashCode();
		}
		if (IPBIOPFGBOM != 0)
		{
			num ^= IPBIOPFGBOM.GetHashCode();
		}
		if (DCPKPNLKGMM != 0)
		{
			num ^= DCPKPNLKGMM.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (HNFDGOMEIFM != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HNFDGOMEIFM);
		}
		if (IPBIOPFGBOM != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(IPBIOPFGBOM);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(DCPKPNLKGMM);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (HNFDGOMEIFM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HNFDGOMEIFM);
		}
		if (IPBIOPFGBOM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPBIOPFGBOM);
		}
		if (DCPKPNLKGMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCPKPNLKGMM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JHKBPIEOLFB other)
	{
		if (other != null)
		{
			if (other.HNFDGOMEIFM != 0)
			{
				HNFDGOMEIFM = other.HNFDGOMEIFM;
			}
			if (other.IPBIOPFGBOM != 0)
			{
				IPBIOPFGBOM = other.IPBIOPFGBOM;
			}
			if (other.DCPKPNLKGMM != 0)
			{
				DCPKPNLKGMM = other.DCPKPNLKGMM;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				HNFDGOMEIFM = input.ReadUInt32();
				break;
			case 64u:
				IPBIOPFGBOM = input.ReadUInt32();
				break;
			case 104u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			}
		}
	}
}
