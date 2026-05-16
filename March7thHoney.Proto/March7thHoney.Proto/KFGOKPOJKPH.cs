using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KFGOKPOJKPH : IMessage<KFGOKPOJKPH>, IMessage, IEquatable<KFGOKPOJKPH>, IDeepCloneable<KFGOKPOJKPH>, IBufferMessage
{
	private static readonly MessageParser<KFGOKPOJKPH> _parser = new MessageParser<KFGOKPOJKPH>(() => new KFGOKPOJKPH());

	private UnknownFieldSet _unknownFields;

	public const int BNPGKDAEJPBFieldNumber = 2;

	private LanguageType bNPGKDAEJPB_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KFGOKPOJKPH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KFGOKPOJKPHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LanguageType BNPGKDAEJPB
	{
		get
		{
			return bNPGKDAEJPB_;
		}
		set
		{
			bNPGKDAEJPB_ = value;
		}
	}

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
	public KFGOKPOJKPH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFGOKPOJKPH(KFGOKPOJKPH other)
		: this()
	{
		bNPGKDAEJPB_ = other.bNPGKDAEJPB_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFGOKPOJKPH Clone()
	{
		return new KFGOKPOJKPH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KFGOKPOJKPH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KFGOKPOJKPH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BNPGKDAEJPB != other.BNPGKDAEJPB)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (BNPGKDAEJPB != LanguageType.LanguageNone)
		{
			num ^= BNPGKDAEJPB.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (BNPGKDAEJPB != LanguageType.LanguageNone)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)BNPGKDAEJPB);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
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
		if (BNPGKDAEJPB != LanguageType.LanguageNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BNPGKDAEJPB);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KFGOKPOJKPH other)
	{
		if (other != null)
		{
			if (other.BNPGKDAEJPB != LanguageType.LanguageNone)
			{
				BNPGKDAEJPB = other.BNPGKDAEJPB;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 16u:
				BNPGKDAEJPB = (LanguageType)input.ReadEnum();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
