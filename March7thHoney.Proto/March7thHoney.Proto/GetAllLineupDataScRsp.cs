using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAllLineupDataScRsp : IMessage<GetAllLineupDataScRsp>, IMessage, IEquatable<GetAllLineupDataScRsp>, IDeepCloneable<GetAllLineupDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetAllLineupDataScRsp> _parser = new MessageParser<GetAllLineupDataScRsp>(() => new GetAllLineupDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int LineupListFieldNumber = 10;

	private static readonly FieldCodec<LineupInfo> _repeated_lineupList_codec = FieldCodec.ForMessage(82u, LineupInfo.Parser);

	private readonly RepeatedField<LineupInfo> lineupList_ = new RepeatedField<LineupInfo>();

	public const int CurIndexFieldNumber = 11;

	private uint curIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAllLineupDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAllLineupDataScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<LineupInfo> LineupList => lineupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurIndex
	{
		get
		{
			return curIndex_;
		}
		set
		{
			curIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAllLineupDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAllLineupDataScRsp(GetAllLineupDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		lineupList_ = other.lineupList_.Clone();
		curIndex_ = other.curIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAllLineupDataScRsp Clone()
	{
		return new GetAllLineupDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAllLineupDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAllLineupDataScRsp other)
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
		if (!lineupList_.Equals(other.lineupList_))
		{
			return false;
		}
		if (CurIndex != other.CurIndex)
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
		num ^= lineupList_.GetHashCode();
		if (CurIndex != 0)
		{
			num ^= CurIndex.GetHashCode();
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
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
		if (CurIndex != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CurIndex);
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
		num += lineupList_.CalculateSize(_repeated_lineupList_codec);
		if (CurIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetAllLineupDataScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			lineupList_.Add(other.lineupList_);
			if (other.CurIndex != 0)
			{
				CurIndex = other.CurIndex;
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
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
				break;
			case 88u:
				CurIndex = input.ReadUInt32();
				break;
			}
		}
	}
}
