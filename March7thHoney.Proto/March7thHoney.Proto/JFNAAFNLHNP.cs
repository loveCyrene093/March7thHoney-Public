using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JFNAAFNLHNP : IMessage<JFNAAFNLHNP>, IMessage, IEquatable<JFNAAFNLHNP>, IDeepCloneable<JFNAAFNLHNP>, IBufferMessage
{
	private static readonly MessageParser<JFNAAFNLHNP> _parser = new MessageParser<JFNAAFNLHNP>(() => new JFNAAFNLHNP());

	private UnknownFieldSet _unknownFields;

	public const int PGHDKFPGPIHFieldNumber = 1;

	private uint pGHDKFPGPIH_;

	public const int KJGBPCEGFAPFieldNumber = 11;

	private uint kJGBPCEGFAP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JFNAAFNLHNP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JFNAAFNLHNPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PGHDKFPGPIH
	{
		get
		{
			return pGHDKFPGPIH_;
		}
		set
		{
			pGHDKFPGPIH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KJGBPCEGFAP
	{
		get
		{
			return kJGBPCEGFAP_;
		}
		set
		{
			kJGBPCEGFAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFNAAFNLHNP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFNAAFNLHNP(JFNAAFNLHNP other)
		: this()
	{
		pGHDKFPGPIH_ = other.pGHDKFPGPIH_;
		kJGBPCEGFAP_ = other.kJGBPCEGFAP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFNAAFNLHNP Clone()
	{
		return new JFNAAFNLHNP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JFNAAFNLHNP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JFNAAFNLHNP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PGHDKFPGPIH != other.PGHDKFPGPIH)
		{
			return false;
		}
		if (KJGBPCEGFAP != other.KJGBPCEGFAP)
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
		if (PGHDKFPGPIH != 0)
		{
			num ^= PGHDKFPGPIH.GetHashCode();
		}
		if (KJGBPCEGFAP != 0)
		{
			num ^= KJGBPCEGFAP.GetHashCode();
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
		if (PGHDKFPGPIH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PGHDKFPGPIH);
		}
		if (KJGBPCEGFAP != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(KJGBPCEGFAP);
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
		if (PGHDKFPGPIH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGHDKFPGPIH);
		}
		if (KJGBPCEGFAP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KJGBPCEGFAP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JFNAAFNLHNP other)
	{
		if (other != null)
		{
			if (other.PGHDKFPGPIH != 0)
			{
				PGHDKFPGPIH = other.PGHDKFPGPIH;
			}
			if (other.KJGBPCEGFAP != 0)
			{
				KJGBPCEGFAP = other.KJGBPCEGFAP;
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
				PGHDKFPGPIH = input.ReadUInt32();
				break;
			case 88u:
				KJGBPCEGFAP = input.ReadUInt32();
				break;
			}
		}
	}
}
