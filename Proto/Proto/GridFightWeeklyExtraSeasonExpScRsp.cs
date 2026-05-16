using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightWeeklyExtraSeasonExpScRsp : IMessage<GridFightWeeklyExtraSeasonExpScRsp>, IMessage, IEquatable<GridFightWeeklyExtraSeasonExpScRsp>, IDeepCloneable<GridFightWeeklyExtraSeasonExpScRsp>, IBufferMessage
{
	private static readonly MessageParser<GridFightWeeklyExtraSeasonExpScRsp> _parser = new MessageParser<GridFightWeeklyExtraSeasonExpScRsp>(() => new GridFightWeeklyExtraSeasonExpScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CurTakenExtraExpFieldNumber = 15;

	private uint curTakenExtraExp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightWeeklyExtraSeasonExpScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightWeeklyExtraSeasonExpScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurTakenExtraExp
	{
		get
		{
			return curTakenExtraExp_;
		}
		set
		{
			curTakenExtraExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightWeeklyExtraSeasonExpScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightWeeklyExtraSeasonExpScRsp(GridFightWeeklyExtraSeasonExpScRsp other)
		: this()
	{
		curTakenExtraExp_ = other.curTakenExtraExp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightWeeklyExtraSeasonExpScRsp Clone()
	{
		return new GridFightWeeklyExtraSeasonExpScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightWeeklyExtraSeasonExpScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightWeeklyExtraSeasonExpScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurTakenExtraExp != other.CurTakenExtraExp)
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
		if (CurTakenExtraExp != 0)
		{
			num ^= CurTakenExtraExp.GetHashCode();
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
		if (CurTakenExtraExp != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(CurTakenExtraExp);
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
		if (CurTakenExtraExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurTakenExtraExp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightWeeklyExtraSeasonExpScRsp other)
	{
		if (other != null)
		{
			if (other.CurTakenExtraExp != 0)
			{
				CurTakenExtraExp = other.CurTakenExtraExp;
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
			if (num != 120)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CurTakenExtraExp = input.ReadUInt32();
			}
		}
	}
}
