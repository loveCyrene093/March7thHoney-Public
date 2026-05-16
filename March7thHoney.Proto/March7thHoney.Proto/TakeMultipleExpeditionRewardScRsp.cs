using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeMultipleExpeditionRewardScRsp : IMessage<TakeMultipleExpeditionRewardScRsp>, IMessage, IEquatable<TakeMultipleExpeditionRewardScRsp>, IDeepCloneable<TakeMultipleExpeditionRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeMultipleExpeditionRewardScRsp> _parser = new MessageParser<TakeMultipleExpeditionRewardScRsp>(() => new TakeMultipleExpeditionRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int KAMBBFDEBAMFieldNumber = 8;

	private long kAMBBFDEBAM_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int HALFGLGLDLOFieldNumber = 12;

	private static readonly FieldCodec<ItemList> _repeated_hALFGLGLDLO_codec = FieldCodec.ForMessage(98u, ItemList.Parser);

	private readonly RepeatedField<ItemList> hALFGLGLDLO_ = new RepeatedField<ItemList>();

	public const int ANMHKDANNDLFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_aNMHKDANNDL_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> aNMHKDANNDL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeMultipleExpeditionRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeMultipleExpeditionRewardScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> ANMHKDANNDL => aNMHKDANNDL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMultipleExpeditionRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMultipleExpeditionRewardScRsp(TakeMultipleExpeditionRewardScRsp other)
		: this()
	{
		kAMBBFDEBAM_ = other.kAMBBFDEBAM_;
		retcode_ = other.retcode_;
		hALFGLGLDLO_ = other.hALFGLGLDLO_.Clone();
		aNMHKDANNDL_ = other.aNMHKDANNDL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMultipleExpeditionRewardScRsp Clone()
	{
		return new TakeMultipleExpeditionRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeMultipleExpeditionRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeMultipleExpeditionRewardScRsp other)
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
		if (!aNMHKDANNDL_.Equals(other.aNMHKDANNDL_))
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
		num ^= aNMHKDANNDL_.GetHashCode();
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
			output.WriteRawTag(64);
			output.WriteInt64(KAMBBFDEBAM);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		hALFGLGLDLO_.WriteTo(ref output, _repeated_hALFGLGLDLO_codec);
		aNMHKDANNDL_.WriteTo(ref output, _repeated_aNMHKDANNDL_codec);
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
		num += aNMHKDANNDL_.CalculateSize(_repeated_aNMHKDANNDL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeMultipleExpeditionRewardScRsp other)
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
			aNMHKDANNDL_.Add(other.aNMHKDANNDL_);
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
			case 64u:
				KAMBBFDEBAM = input.ReadInt64();
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				hALFGLGLDLO_.AddEntriesFrom(ref input, _repeated_hALFGLGLDLO_codec);
				break;
			case 120u:
			case 122u:
				aNMHKDANNDL_.AddEntriesFrom(ref input, _repeated_aNMHKDANNDL_codec);
				break;
			}
		}
	}
}
