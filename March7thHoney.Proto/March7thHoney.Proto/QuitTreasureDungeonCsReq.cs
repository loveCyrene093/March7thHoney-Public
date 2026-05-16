using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuitTreasureDungeonCsReq : IMessage<QuitTreasureDungeonCsReq>, IMessage, IEquatable<QuitTreasureDungeonCsReq>, IDeepCloneable<QuitTreasureDungeonCsReq>, IBufferMessage
{
	private static readonly MessageParser<QuitTreasureDungeonCsReq> _parser = new MessageParser<QuitTreasureDungeonCsReq>(() => new QuitTreasureDungeonCsReq());

	private UnknownFieldSet _unknownFields;

	public const int TargetSideFieldNumber = 1;

	private uint targetSide_;

	public const int PAMDLHOCMCCFieldNumber = 7;

	private bool pAMDLHOCMCC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuitTreasureDungeonCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuitTreasureDungeonCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PAMDLHOCMCC
	{
		get
		{
			return pAMDLHOCMCC_;
		}
		set
		{
			pAMDLHOCMCC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitTreasureDungeonCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitTreasureDungeonCsReq(QuitTreasureDungeonCsReq other)
		: this()
	{
		targetSide_ = other.targetSide_;
		pAMDLHOCMCC_ = other.pAMDLHOCMCC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuitTreasureDungeonCsReq Clone()
	{
		return new QuitTreasureDungeonCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuitTreasureDungeonCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuitTreasureDungeonCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TargetSide != other.TargetSide)
		{
			return false;
		}
		if (PAMDLHOCMCC != other.PAMDLHOCMCC)
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
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
		}
		if (PAMDLHOCMCC)
		{
			num ^= PAMDLHOCMCC.GetHashCode();
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
		if (TargetSide != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TargetSide);
		}
		if (PAMDLHOCMCC)
		{
			output.WriteRawTag(56);
			output.WriteBool(PAMDLHOCMCC);
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
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (PAMDLHOCMCC)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuitTreasureDungeonCsReq other)
	{
		if (other != null)
		{
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
			}
			if (other.PAMDLHOCMCC)
			{
				PAMDLHOCMCC = other.PAMDLHOCMCC;
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
			case 8u:
				TargetSide = input.ReadUInt32();
				break;
			case 56u:
				PAMDLHOCMCC = input.ReadBool();
				break;
			}
		}
	}
}
