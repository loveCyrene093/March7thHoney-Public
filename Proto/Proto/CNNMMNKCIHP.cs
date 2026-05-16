using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CNNMMNKCIHP : IMessage<CNNMMNKCIHP>, IMessage, IEquatable<CNNMMNKCIHP>, IDeepCloneable<CNNMMNKCIHP>, IBufferMessage
{
	private static readonly MessageParser<CNNMMNKCIHP> _parser = new MessageParser<CNNMMNKCIHP>(() => new CNNMMNKCIHP());

	private UnknownFieldSet _unknownFields;

	public const int PGBPLONOIPEFieldNumber = 5;

	private uint pGBPLONOIPE_;

	public const int MHMJGPMKPDLFieldNumber = 6;

	private uint mHMJGPMKPDL_;

	public const int JMLMMJCIMHCFieldNumber = 11;

	private uint jMLMMJCIMHC_;

	public const int HGBGJACAOHBFieldNumber = 12;

	private uint hGBGJACAOHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CNNMMNKCIHP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CNNMMNKCIHPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PGBPLONOIPE
	{
		get
		{
			return pGBPLONOIPE_;
		}
		set
		{
			pGBPLONOIPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MHMJGPMKPDL
	{
		get
		{
			return mHMJGPMKPDL_;
		}
		set
		{
			mHMJGPMKPDL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JMLMMJCIMHC
	{
		get
		{
			return jMLMMJCIMHC_;
		}
		set
		{
			jMLMMJCIMHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HGBGJACAOHB
	{
		get
		{
			return hGBGJACAOHB_;
		}
		set
		{
			hGBGJACAOHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNNMMNKCIHP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNNMMNKCIHP(CNNMMNKCIHP other)
		: this()
	{
		pGBPLONOIPE_ = other.pGBPLONOIPE_;
		mHMJGPMKPDL_ = other.mHMJGPMKPDL_;
		jMLMMJCIMHC_ = other.jMLMMJCIMHC_;
		hGBGJACAOHB_ = other.hGBGJACAOHB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNNMMNKCIHP Clone()
	{
		return new CNNMMNKCIHP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CNNMMNKCIHP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CNNMMNKCIHP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PGBPLONOIPE != other.PGBPLONOIPE)
		{
			return false;
		}
		if (MHMJGPMKPDL != other.MHMJGPMKPDL)
		{
			return false;
		}
		if (JMLMMJCIMHC != other.JMLMMJCIMHC)
		{
			return false;
		}
		if (HGBGJACAOHB != other.HGBGJACAOHB)
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
		if (PGBPLONOIPE != 0)
		{
			num ^= PGBPLONOIPE.GetHashCode();
		}
		if (MHMJGPMKPDL != 0)
		{
			num ^= MHMJGPMKPDL.GetHashCode();
		}
		if (JMLMMJCIMHC != 0)
		{
			num ^= JMLMMJCIMHC.GetHashCode();
		}
		if (HGBGJACAOHB != 0)
		{
			num ^= HGBGJACAOHB.GetHashCode();
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
		if (PGBPLONOIPE != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PGBPLONOIPE);
		}
		if (MHMJGPMKPDL != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MHMJGPMKPDL);
		}
		if (JMLMMJCIMHC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(JMLMMJCIMHC);
		}
		if (HGBGJACAOHB != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(HGBGJACAOHB);
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
		if (PGBPLONOIPE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGBPLONOIPE);
		}
		if (MHMJGPMKPDL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MHMJGPMKPDL);
		}
		if (JMLMMJCIMHC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JMLMMJCIMHC);
		}
		if (HGBGJACAOHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HGBGJACAOHB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CNNMMNKCIHP other)
	{
		if (other != null)
		{
			if (other.PGBPLONOIPE != 0)
			{
				PGBPLONOIPE = other.PGBPLONOIPE;
			}
			if (other.MHMJGPMKPDL != 0)
			{
				MHMJGPMKPDL = other.MHMJGPMKPDL;
			}
			if (other.JMLMMJCIMHC != 0)
			{
				JMLMMJCIMHC = other.JMLMMJCIMHC;
			}
			if (other.HGBGJACAOHB != 0)
			{
				HGBGJACAOHB = other.HGBGJACAOHB;
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
			case 40u:
				PGBPLONOIPE = input.ReadUInt32();
				break;
			case 48u:
				MHMJGPMKPDL = input.ReadUInt32();
				break;
			case 88u:
				JMLMMJCIMHC = input.ReadUInt32();
				break;
			case 96u:
				HGBGJACAOHB = input.ReadUInt32();
				break;
			}
		}
	}
}
