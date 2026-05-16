using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DEBHHHIFIHK : IMessage<DEBHHHIFIHK>, IMessage, IEquatable<DEBHHHIFIHK>, IDeepCloneable<DEBHHHIFIHK>, IBufferMessage
{
	private static readonly MessageParser<DEBHHHIFIHK> _parser = new MessageParser<DEBHHHIFIHK>(() => new DEBHHHIFIHK());

	private UnknownFieldSet _unknownFields;

	public const int PNKGNIIDJAAFieldNumber = 6;

	private uint pNKGNIIDJAA_;

	public const int DCPKPNLKGMMFieldNumber = 7;

	private uint dCPKPNLKGMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DEBHHHIFIHK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DEBHHHIFIHKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNKGNIIDJAA
	{
		get
		{
			return pNKGNIIDJAA_;
		}
		set
		{
			pNKGNIIDJAA_ = value;
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
	public DEBHHHIFIHK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEBHHHIFIHK(DEBHHHIFIHK other)
		: this()
	{
		pNKGNIIDJAA_ = other.pNKGNIIDJAA_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEBHHHIFIHK Clone()
	{
		return new DEBHHHIFIHK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DEBHHHIFIHK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DEBHHHIFIHK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PNKGNIIDJAA != other.PNKGNIIDJAA)
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
		if (PNKGNIIDJAA != 0)
		{
			num ^= PNKGNIIDJAA.GetHashCode();
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
		if (PNKGNIIDJAA != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PNKGNIIDJAA);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(56);
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
		if (PNKGNIIDJAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNKGNIIDJAA);
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
	public void MergeFrom(DEBHHHIFIHK other)
	{
		if (other != null)
		{
			if (other.PNKGNIIDJAA != 0)
			{
				PNKGNIIDJAA = other.PNKGNIIDJAA;
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
			case 48u:
				PNKGNIIDJAA = input.ReadUInt32();
				break;
			case 56u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			}
		}
	}
}
