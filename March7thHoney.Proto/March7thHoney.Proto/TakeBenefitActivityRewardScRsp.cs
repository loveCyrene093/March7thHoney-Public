using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeBenefitActivityRewardScRsp : IMessage<TakeBenefitActivityRewardScRsp>, IMessage, IEquatable<TakeBenefitActivityRewardScRsp>, IDeepCloneable<TakeBenefitActivityRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeBenefitActivityRewardScRsp> _parser = new MessageParser<TakeBenefitActivityRewardScRsp>(() => new TakeBenefitActivityRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int SwitchListFieldNumber = 2;

	private static readonly FieldCodec<DOMOEOOHLJA> _repeated_switchList_codec = FieldCodec.ForMessage(18u, DOMOEOOHLJA.Parser);

	private readonly RepeatedField<DOMOEOOHLJA> switchList_ = new RepeatedField<DOMOEOOHLJA>();

	public const int DBMFJIIOFOIFieldNumber = 13;

	private ItemList dBMFJIIOFOI_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeBenefitActivityRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeBenefitActivityRewardScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DOMOEOOHLJA> SwitchList => switchList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList DBMFJIIOFOI
	{
		get
		{
			return dBMFJIIOFOI_;
		}
		set
		{
			dBMFJIIOFOI_ = value;
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
	public TakeBenefitActivityRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeBenefitActivityRewardScRsp(TakeBenefitActivityRewardScRsp other)
		: this()
	{
		switchList_ = other.switchList_.Clone();
		dBMFJIIOFOI_ = ((other.dBMFJIIOFOI_ != null) ? other.dBMFJIIOFOI_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeBenefitActivityRewardScRsp Clone()
	{
		return new TakeBenefitActivityRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeBenefitActivityRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeBenefitActivityRewardScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!switchList_.Equals(other.switchList_))
		{
			return false;
		}
		if (!object.Equals(DBMFJIIOFOI, other.DBMFJIIOFOI))
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
		num ^= switchList_.GetHashCode();
		if (dBMFJIIOFOI_ != null)
		{
			num ^= DBMFJIIOFOI.GetHashCode();
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
		switchList_.WriteTo(ref output, _repeated_switchList_codec);
		if (dBMFJIIOFOI_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(DBMFJIIOFOI);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
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
		num += switchList_.CalculateSize(_repeated_switchList_codec);
		if (dBMFJIIOFOI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DBMFJIIOFOI);
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
	public void MergeFrom(TakeBenefitActivityRewardScRsp other)
	{
		if (other == null)
		{
			return;
		}
		switchList_.Add(other.switchList_);
		if (other.dBMFJIIOFOI_ != null)
		{
			if (dBMFJIIOFOI_ == null)
			{
				DBMFJIIOFOI = new ItemList();
			}
			DBMFJIIOFOI.MergeFrom(other.DBMFJIIOFOI);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 18u:
				switchList_.AddEntriesFrom(ref input, _repeated_switchList_codec);
				break;
			case 106u:
				if (dBMFJIIOFOI_ == null)
				{
					DBMFJIIOFOI = new ItemList();
				}
				input.ReadMessage(DBMFJIIOFOI);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
