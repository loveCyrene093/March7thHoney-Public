using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SearchPlayerScRsp : IMessage<SearchPlayerScRsp>, IMessage, IEquatable<SearchPlayerScRsp>, IDeepCloneable<SearchPlayerScRsp>, IBufferMessage
{
	private static readonly MessageParser<SearchPlayerScRsp> _parser = new MessageParser<SearchPlayerScRsp>(() => new SearchPlayerScRsp());

	private UnknownFieldSet _unknownFields;

	public const int SimpleInfoListFieldNumber = 7;

	private static readonly FieldCodec<PlayerSimpleInfo> _repeated_simpleInfoList_codec = FieldCodec.ForMessage(58u, PlayerSimpleInfo.Parser);

	private readonly RepeatedField<PlayerSimpleInfo> simpleInfoList_ = new RepeatedField<PlayerSimpleInfo>();

	public const int ResultUidListFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_resultUidList_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> resultUidList_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SearchPlayerScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SearchPlayerScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PlayerSimpleInfo> SimpleInfoList => simpleInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ResultUidList => resultUidList_;

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
	public SearchPlayerScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SearchPlayerScRsp(SearchPlayerScRsp other)
		: this()
	{
		simpleInfoList_ = other.simpleInfoList_.Clone();
		resultUidList_ = other.resultUidList_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SearchPlayerScRsp Clone()
	{
		return new SearchPlayerScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SearchPlayerScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SearchPlayerScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!simpleInfoList_.Equals(other.simpleInfoList_))
		{
			return false;
		}
		if (!resultUidList_.Equals(other.resultUidList_))
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
		num ^= simpleInfoList_.GetHashCode();
		num ^= resultUidList_.GetHashCode();
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
		simpleInfoList_.WriteTo(ref output, _repeated_simpleInfoList_codec);
		resultUidList_.WriteTo(ref output, _repeated_resultUidList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
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
		num += simpleInfoList_.CalculateSize(_repeated_simpleInfoList_codec);
		num += resultUidList_.CalculateSize(_repeated_resultUidList_codec);
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
	public void MergeFrom(SearchPlayerScRsp other)
	{
		if (other != null)
		{
			simpleInfoList_.Add(other.simpleInfoList_);
			resultUidList_.Add(other.resultUidList_);
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
			case 58u:
				simpleInfoList_.AddEntriesFrom(ref input, _repeated_simpleInfoList_codec);
				break;
			case 80u:
			case 82u:
				resultUidList_.AddEntriesFrom(ref input, _repeated_resultUidList_codec);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
