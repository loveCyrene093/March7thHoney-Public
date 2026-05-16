using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSyncKeepWinCntNotify : IMessage<GridFightSyncKeepWinCntNotify>, IMessage, IEquatable<GridFightSyncKeepWinCntNotify>, IDeepCloneable<GridFightSyncKeepWinCntNotify>, IBufferMessage
{
	private static readonly MessageParser<GridFightSyncKeepWinCntNotify> _parser = new MessageParser<GridFightSyncKeepWinCntNotify>(() => new GridFightSyncKeepWinCntNotify());

	private UnknownFieldSet _unknownFields;

	public const int LBJPDJFHIBFFieldNumber = 4;

	private uint lBJPDJFHIBF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSyncKeepWinCntNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSyncKeepWinCntNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LBJPDJFHIBF
	{
		get
		{
			return lBJPDJFHIBF_;
		}
		set
		{
			lBJPDJFHIBF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncKeepWinCntNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncKeepWinCntNotify(GridFightSyncKeepWinCntNotify other)
		: this()
	{
		lBJPDJFHIBF_ = other.lBJPDJFHIBF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSyncKeepWinCntNotify Clone()
	{
		return new GridFightSyncKeepWinCntNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSyncKeepWinCntNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSyncKeepWinCntNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LBJPDJFHIBF != other.LBJPDJFHIBF)
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
		if (LBJPDJFHIBF != 0)
		{
			num ^= LBJPDJFHIBF.GetHashCode();
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
		if (LBJPDJFHIBF != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LBJPDJFHIBF);
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
		if (LBJPDJFHIBF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LBJPDJFHIBF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSyncKeepWinCntNotify other)
	{
		if (other != null)
		{
			if (other.LBJPDJFHIBF != 0)
			{
				LBJPDJFHIBF = other.LBJPDJFHIBF;
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
			if (num != 32)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				LBJPDJFHIBF = input.ReadUInt32();
			}
		}
	}
}
