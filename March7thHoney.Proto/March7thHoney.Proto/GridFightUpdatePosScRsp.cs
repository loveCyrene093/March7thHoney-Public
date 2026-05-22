using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightUpdatePosScRsp : IMessage<GridFightUpdatePosScRsp>, IMessage, IEquatable<GridFightUpdatePosScRsp>, IDeepCloneable<GridFightUpdatePosScRsp>, IBufferMessage
{
	private static readonly MessageParser<GridFightUpdatePosScRsp> _parser = new MessageParser<GridFightUpdatePosScRsp>(() => new GridFightUpdatePosScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int GridFightPosInfoListFieldNumber = 9;

	private static readonly FieldCodec<GridFightPosInfo> _repeated_gridFightPosInfoList_codec = FieldCodec.ForMessage(74u, GridFightPosInfo.Parser);

	private readonly RepeatedField<GridFightPosInfo> gridFightPosInfoList_ = new RepeatedField<GridFightPosInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightUpdatePosScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightUpdatePosScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<GridFightPosInfo> GridFightPosInfoList => gridFightPosInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdatePosScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdatePosScRsp(GridFightUpdatePosScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		gridFightPosInfoList_ = other.gridFightPosInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdatePosScRsp Clone()
	{
		return new GridFightUpdatePosScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightUpdatePosScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightUpdatePosScRsp other)
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
		if (!gridFightPosInfoList_.Equals(other.gridFightPosInfoList_))
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
		num ^= gridFightPosInfoList_.GetHashCode();
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
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		gridFightPosInfoList_.WriteTo(ref output, _repeated_gridFightPosInfoList_codec);
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
		num += gridFightPosInfoList_.CalculateSize(_repeated_gridFightPosInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightUpdatePosScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			gridFightPosInfoList_.Add(other.gridFightPosInfoList_);
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
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				gridFightPosInfoList_.AddEntriesFrom(ref input, _repeated_gridFightPosInfoList_codec);
				break;
			}
		}
	}
}
