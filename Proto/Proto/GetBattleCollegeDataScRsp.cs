using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetBattleCollegeDataScRsp : IMessage<GetBattleCollegeDataScRsp>, IMessage, IEquatable<GetBattleCollegeDataScRsp>, IDeepCloneable<GetBattleCollegeDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetBattleCollegeDataScRsp> _parser = new MessageParser<GetBattleCollegeDataScRsp>(() => new GetBattleCollegeDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LCDALEEEDJJFieldNumber = 5;

	private uint lCDALEEEDJJ_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int FinishedCollegeIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_finishedCollegeIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> finishedCollegeIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetBattleCollegeDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetBattleCollegeDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LCDALEEEDJJ
	{
		get
		{
			return lCDALEEEDJJ_;
		}
		set
		{
			lCDALEEEDJJ_ = value;
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
	public RepeatedField<uint> FinishedCollegeIdList => finishedCollegeIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBattleCollegeDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBattleCollegeDataScRsp(GetBattleCollegeDataScRsp other)
		: this()
	{
		lCDALEEEDJJ_ = other.lCDALEEEDJJ_;
		retcode_ = other.retcode_;
		finishedCollegeIdList_ = other.finishedCollegeIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBattleCollegeDataScRsp Clone()
	{
		return new GetBattleCollegeDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetBattleCollegeDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetBattleCollegeDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LCDALEEEDJJ != other.LCDALEEEDJJ)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!finishedCollegeIdList_.Equals(other.finishedCollegeIdList_))
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
		if (LCDALEEEDJJ != 0)
		{
			num ^= LCDALEEEDJJ.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= finishedCollegeIdList_.GetHashCode();
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
		if (LCDALEEEDJJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(LCDALEEEDJJ);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		finishedCollegeIdList_.WriteTo(ref output, _repeated_finishedCollegeIdList_codec);
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
		if (LCDALEEEDJJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LCDALEEEDJJ);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += finishedCollegeIdList_.CalculateSize(_repeated_finishedCollegeIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetBattleCollegeDataScRsp other)
	{
		if (other != null)
		{
			if (other.LCDALEEEDJJ != 0)
			{
				LCDALEEEDJJ = other.LCDALEEEDJJ;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			finishedCollegeIdList_.Add(other.finishedCollegeIdList_);
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
				LCDALEEEDJJ = input.ReadUInt32();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				finishedCollegeIdList_.AddEntriesFrom(ref input, _repeated_finishedCollegeIdList_codec);
				break;
			}
		}
	}
}
