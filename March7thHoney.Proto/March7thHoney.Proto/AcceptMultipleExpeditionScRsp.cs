using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AcceptMultipleExpeditionScRsp : IMessage<AcceptMultipleExpeditionScRsp>, IMessage, IEquatable<AcceptMultipleExpeditionScRsp>, IDeepCloneable<AcceptMultipleExpeditionScRsp>, IBufferMessage
{
	private static readonly MessageParser<AcceptMultipleExpeditionScRsp> _parser = new MessageParser<AcceptMultipleExpeditionScRsp>(() => new AcceptMultipleExpeditionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int KAMBBFDEBAMFieldNumber = 7;

	private long kAMBBFDEBAM_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int HALFGLGLDLOFieldNumber = 14;

	private static readonly FieldCodec<ItemList> _repeated_hALFGLGLDLO_codec = FieldCodec.ForMessage(114u, ItemList.Parser);

	private readonly RepeatedField<ItemList> hALFGLGLDLO_ = new RepeatedField<ItemList>();

	public const int AcceptMultiExpeditionFieldNumber = 15;

	private static readonly FieldCodec<ExpeditionInfo> _repeated_acceptMultiExpedition_codec = FieldCodec.ForMessage(122u, ExpeditionInfo.Parser);

	private readonly RepeatedField<ExpeditionInfo> acceptMultiExpedition_ = new RepeatedField<ExpeditionInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AcceptMultipleExpeditionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AcceptMultipleExpeditionScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long KAMBBFDEBAM
	{
		get
		{
			return kAMBBFDEBAM_;
		}
		set
		{
			kAMBBFDEBAM_ = value;
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
	public RepeatedField<ItemList> HALFGLGLDLO => hALFGLGLDLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ExpeditionInfo> AcceptMultiExpedition => acceptMultiExpedition_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcceptMultipleExpeditionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcceptMultipleExpeditionScRsp(AcceptMultipleExpeditionScRsp other)
		: this()
	{
		kAMBBFDEBAM_ = other.kAMBBFDEBAM_;
		retcode_ = other.retcode_;
		hALFGLGLDLO_ = other.hALFGLGLDLO_.Clone();
		acceptMultiExpedition_ = other.acceptMultiExpedition_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AcceptMultipleExpeditionScRsp Clone()
	{
		return new AcceptMultipleExpeditionScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AcceptMultipleExpeditionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AcceptMultipleExpeditionScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KAMBBFDEBAM != other.KAMBBFDEBAM)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!hALFGLGLDLO_.Equals(other.hALFGLGLDLO_))
		{
			return false;
		}
		if (!acceptMultiExpedition_.Equals(other.acceptMultiExpedition_))
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
		if (KAMBBFDEBAM != 0L)
		{
			num ^= KAMBBFDEBAM.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= hALFGLGLDLO_.GetHashCode();
		num ^= acceptMultiExpedition_.GetHashCode();
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
		if (KAMBBFDEBAM != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(KAMBBFDEBAM);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		hALFGLGLDLO_.WriteTo(ref output, _repeated_hALFGLGLDLO_codec);
		acceptMultiExpedition_.WriteTo(ref output, _repeated_acceptMultiExpedition_codec);
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
		if (KAMBBFDEBAM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(KAMBBFDEBAM);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += hALFGLGLDLO_.CalculateSize(_repeated_hALFGLGLDLO_codec);
		num += acceptMultiExpedition_.CalculateSize(_repeated_acceptMultiExpedition_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AcceptMultipleExpeditionScRsp other)
	{
		if (other != null)
		{
			if (other.KAMBBFDEBAM != 0L)
			{
				KAMBBFDEBAM = other.KAMBBFDEBAM;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			hALFGLGLDLO_.Add(other.hALFGLGLDLO_);
			acceptMultiExpedition_.Add(other.acceptMultiExpedition_);
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
			case 56u:
				KAMBBFDEBAM = input.ReadInt64();
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				hALFGLGLDLO_.AddEntriesFrom(ref input, _repeated_hALFGLGLDLO_codec);
				break;
			case 122u:
				acceptMultiExpedition_.AddEntriesFrom(ref input, _repeated_acceptMultiExpedition_codec);
				break;
			}
		}
	}
}
