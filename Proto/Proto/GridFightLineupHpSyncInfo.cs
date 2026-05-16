using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightLineupHpSyncInfo : IMessage<GridFightLineupHpSyncInfo>, IMessage, IEquatable<GridFightLineupHpSyncInfo>, IDeepCloneable<GridFightLineupHpSyncInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightLineupHpSyncInfo> _parser = new MessageParser<GridFightLineupHpSyncInfo>(() => new GridFightLineupHpSyncInfo());

	private UnknownFieldSet _unknownFields;

	public const int GridFightLineupMaxHpFieldNumber = 13;

	private uint gridFightLineupMaxHp_;

	public const int GridFightLineupHpFieldNumber = 14;

	private uint gridFightLineupHp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightLineupHpSyncInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightLineupHpSyncInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightLineupMaxHp
	{
		get
		{
			return gridFightLineupMaxHp_;
		}
		set
		{
			gridFightLineupMaxHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightLineupHp
	{
		get
		{
			return gridFightLineupHp_;
		}
		set
		{
			gridFightLineupHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLineupHpSyncInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLineupHpSyncInfo(GridFightLineupHpSyncInfo other)
		: this()
	{
		gridFightLineupMaxHp_ = other.gridFightLineupMaxHp_;
		gridFightLineupHp_ = other.gridFightLineupHp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLineupHpSyncInfo Clone()
	{
		return new GridFightLineupHpSyncInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightLineupHpSyncInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightLineupHpSyncInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GridFightLineupMaxHp != other.GridFightLineupMaxHp)
		{
			return false;
		}
		if (GridFightLineupHp != other.GridFightLineupHp)
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
		if (GridFightLineupMaxHp != 0)
		{
			num ^= GridFightLineupMaxHp.GetHashCode();
		}
		if (GridFightLineupHp != 0)
		{
			num ^= GridFightLineupHp.GetHashCode();
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
		if (GridFightLineupMaxHp != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GridFightLineupMaxHp);
		}
		if (GridFightLineupHp != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GridFightLineupHp);
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
		if (GridFightLineupMaxHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightLineupMaxHp);
		}
		if (GridFightLineupHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightLineupHp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightLineupHpSyncInfo other)
	{
		if (other != null)
		{
			if (other.GridFightLineupMaxHp != 0)
			{
				GridFightLineupMaxHp = other.GridFightLineupMaxHp;
			}
			if (other.GridFightLineupHp != 0)
			{
				GridFightLineupHp = other.GridFightLineupHp;
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
			case 104u:
				GridFightLineupMaxHp = input.ReadUInt32();
				break;
			case 112u:
				GridFightLineupHp = input.ReadUInt32();
				break;
			}
		}
	}
}
