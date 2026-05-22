using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CancelSyncExpiredItemCsReq : IMessage<CancelSyncExpiredItemCsReq>, IMessage, IEquatable<CancelSyncExpiredItemCsReq>, IDeepCloneable<CancelSyncExpiredItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<CancelSyncExpiredItemCsReq> _parser = new MessageParser<CancelSyncExpiredItemCsReq>(() => new CancelSyncExpiredItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 3;

	private JMGCDIANLGK type_;

	public const int COOOFFKIDMCFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_cOOOFFKIDMC_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> cOOOFFKIDMC_ = new RepeatedField<uint>();

	public const int JLLKNNFAPEEFieldNumber = 14;

	private static readonly FieldCodec<string> _repeated_jLLKNNFAPEE_codec = FieldCodec.ForString(114u);

	private readonly RepeatedField<string> jLLKNNFAPEE_ = new RepeatedField<string>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CancelSyncExpiredItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CancelSyncExpiredItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMGCDIANLGK Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> COOOFFKIDMC => cOOOFFKIDMC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> JLLKNNFAPEE => jLLKNNFAPEE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CancelSyncExpiredItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CancelSyncExpiredItemCsReq(CancelSyncExpiredItemCsReq other)
		: this()
	{
		type_ = other.type_;
		cOOOFFKIDMC_ = other.cOOOFFKIDMC_.Clone();
		jLLKNNFAPEE_ = other.jLLKNNFAPEE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CancelSyncExpiredItemCsReq Clone()
	{
		return new CancelSyncExpiredItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CancelSyncExpiredItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CancelSyncExpiredItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (!cOOOFFKIDMC_.Equals(other.cOOOFFKIDMC_))
		{
			return false;
		}
		if (!jLLKNNFAPEE_.Equals(other.jLLKNNFAPEE_))
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
		if (Type != JMGCDIANLGK.Pcpdhelpkem)
		{
			num ^= Type.GetHashCode();
		}
		num ^= cOOOFFKIDMC_.GetHashCode();
		num ^= jLLKNNFAPEE_.GetHashCode();
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
		if (Type != JMGCDIANLGK.Pcpdhelpkem)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Type);
		}
		cOOOFFKIDMC_.WriteTo(ref output, _repeated_cOOOFFKIDMC_codec);
		jLLKNNFAPEE_.WriteTo(ref output, _repeated_jLLKNNFAPEE_codec);
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
		if (Type != JMGCDIANLGK.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		num += cOOOFFKIDMC_.CalculateSize(_repeated_cOOOFFKIDMC_codec);
		num += jLLKNNFAPEE_.CalculateSize(_repeated_jLLKNNFAPEE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CancelSyncExpiredItemCsReq other)
	{
		if (other != null)
		{
			if (other.Type != JMGCDIANLGK.Pcpdhelpkem)
			{
				Type = other.Type;
			}
			cOOOFFKIDMC_.Add(other.cOOOFFKIDMC_);
			jLLKNNFAPEE_.Add(other.jLLKNNFAPEE_);
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
				Type = (JMGCDIANLGK)input.ReadEnum();
				break;
			case 48u:
			case 50u:
				cOOOFFKIDMC_.AddEntriesFrom(ref input, _repeated_cOOOFFKIDMC_codec);
				break;
			case 114u:
				jLLKNNFAPEE_.AddEntriesFrom(ref input, _repeated_jLLKNNFAPEE_codec);
				break;
			}
		}
	}
}
