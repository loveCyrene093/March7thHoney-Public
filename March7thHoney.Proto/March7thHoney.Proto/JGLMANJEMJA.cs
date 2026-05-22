using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JGLMANJEMJA : IMessage<JGLMANJEMJA>, IMessage, IEquatable<JGLMANJEMJA>, IDeepCloneable<JGLMANJEMJA>, IBufferMessage
{
	private static readonly MessageParser<JGLMANJEMJA> _parser = new MessageParser<JGLMANJEMJA>(() => new JGLMANJEMJA());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int OPGDCBDBKBOFieldNumber = 10;

	private uint oPGDCBDBKBO_;

	public const int DCPKPNLKGMMFieldNumber = 14;

	private uint dCPKPNLKGMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JGLMANJEMJA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JGLMANJEMJAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPGDCBDBKBO
	{
		get
		{
			return oPGDCBDBKBO_;
		}
		set
		{
			oPGDCBDBKBO_ = value;
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
	public JGLMANJEMJA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGLMANJEMJA(JGLMANJEMJA other)
		: this()
	{
		retcode_ = other.retcode_;
		oPGDCBDBKBO_ = other.oPGDCBDBKBO_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGLMANJEMJA Clone()
	{
		return new JGLMANJEMJA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JGLMANJEMJA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JGLMANJEMJA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (OPGDCBDBKBO != other.OPGDCBDBKBO)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (OPGDCBDBKBO != 0)
		{
			num ^= OPGDCBDBKBO.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (OPGDCBDBKBO != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(OPGDCBDBKBO);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(112);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (OPGDCBDBKBO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPGDCBDBKBO);
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
	public void MergeFrom(JGLMANJEMJA other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.OPGDCBDBKBO != 0)
			{
				OPGDCBDBKBO = other.OPGDCBDBKBO;
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
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 80u:
				OPGDCBDBKBO = input.ReadUInt32();
				break;
			case 112u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			}
		}
	}
}
