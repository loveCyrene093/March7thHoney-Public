using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridGameOrbInfo1 : IMessage<GridGameOrbInfo1>, IMessage, IEquatable<GridGameOrbInfo1>, IDeepCloneable<GridGameOrbInfo1>, IBufferMessage
{
	private static readonly MessageParser<GridGameOrbInfo1> _parser = new MessageParser<GridGameOrbInfo1>(() => new GridGameOrbInfo1());

	private UnknownFieldSet _unknownFields;

	public const int FKPNNOGPCNAFieldNumber = 5;

	private uint fKPNNOGPCNA_;

	public const int FCFDDBCAJODFieldNumber = 11;

	private uint fCFDDBCAJOD_;

	public const int UniqueIdFieldNumber = 12;

	private uint uniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridGameOrbInfo1> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridGameOrbInfo1Reflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FKPNNOGPCNA
	{
		get
		{
			return fKPNNOGPCNA_;
		}
		set
		{
			fKPNNOGPCNA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCFDDBCAJOD
	{
		get
		{
			return fCFDDBCAJOD_;
		}
		set
		{
			fCFDDBCAJOD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameOrbInfo1()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameOrbInfo1(GridGameOrbInfo1 other)
		: this()
	{
		fKPNNOGPCNA_ = other.fKPNNOGPCNA_;
		fCFDDBCAJOD_ = other.fCFDDBCAJOD_;
		uniqueId_ = other.uniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameOrbInfo1 Clone()
	{
		return new GridGameOrbInfo1(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridGameOrbInfo1);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridGameOrbInfo1 other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FKPNNOGPCNA != other.FKPNNOGPCNA)
		{
			return false;
		}
		if (FCFDDBCAJOD != other.FCFDDBCAJOD)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
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
		if (FKPNNOGPCNA != 0)
		{
			num ^= FKPNNOGPCNA.GetHashCode();
		}
		if (FCFDDBCAJOD != 0)
		{
			num ^= FCFDDBCAJOD.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
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
		if (FKPNNOGPCNA != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(FKPNNOGPCNA);
		}
		if (FCFDDBCAJOD != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FCFDDBCAJOD);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(UniqueId);
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
		if (FKPNNOGPCNA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FKPNNOGPCNA);
		}
		if (FCFDDBCAJOD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCFDDBCAJOD);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridGameOrbInfo1 other)
	{
		if (other != null)
		{
			if (other.FKPNNOGPCNA != 0)
			{
				FKPNNOGPCNA = other.FKPNNOGPCNA;
			}
			if (other.FCFDDBCAJOD != 0)
			{
				FCFDDBCAJOD = other.FCFDDBCAJOD;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
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
			case 40u:
				FKPNNOGPCNA = input.ReadUInt32();
				break;
			case 88u:
				FCFDDBCAJOD = input.ReadUInt32();
				break;
			case 96u:
				UniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
