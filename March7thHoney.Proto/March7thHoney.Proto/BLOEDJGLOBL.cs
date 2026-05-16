using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BLOEDJGLOBL : IMessage<BLOEDJGLOBL>, IMessage, IEquatable<BLOEDJGLOBL>, IDeepCloneable<BLOEDJGLOBL>, IBufferMessage
{
	private static readonly MessageParser<BLOEDJGLOBL> _parser = new MessageParser<BLOEDJGLOBL>(() => new BLOEDJGLOBL());

	private UnknownFieldSet _unknownFields;

	public const int DGFGNMJALGJFieldNumber = 3;

	private DKBNGDHCNCH dGFGNMJALGJ_;

	public const int PassengerIdFieldNumber = 7;

	private uint passengerId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BLOEDJGLOBL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BLOEDJGLOBLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBNGDHCNCH DGFGNMJALGJ
	{
		get
		{
			return dGFGNMJALGJ_;
		}
		set
		{
			dGFGNMJALGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PassengerId
	{
		get
		{
			return passengerId_;
		}
		set
		{
			passengerId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLOEDJGLOBL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLOEDJGLOBL(BLOEDJGLOBL other)
		: this()
	{
		dGFGNMJALGJ_ = ((other.dGFGNMJALGJ_ != null) ? other.dGFGNMJALGJ_.Clone() : null);
		passengerId_ = other.passengerId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLOEDJGLOBL Clone()
	{
		return new BLOEDJGLOBL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BLOEDJGLOBL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BLOEDJGLOBL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DGFGNMJALGJ, other.DGFGNMJALGJ))
		{
			return false;
		}
		if (PassengerId != other.PassengerId)
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
		if (dGFGNMJALGJ_ != null)
		{
			num ^= DGFGNMJALGJ.GetHashCode();
		}
		if (PassengerId != 0)
		{
			num ^= PassengerId.GetHashCode();
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
		if (dGFGNMJALGJ_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(DGFGNMJALGJ);
		}
		if (PassengerId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(PassengerId);
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
		if (dGFGNMJALGJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DGFGNMJALGJ);
		}
		if (PassengerId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PassengerId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BLOEDJGLOBL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dGFGNMJALGJ_ != null)
		{
			if (dGFGNMJALGJ_ == null)
			{
				DGFGNMJALGJ = new DKBNGDHCNCH();
			}
			DGFGNMJALGJ.MergeFrom(other.DGFGNMJALGJ);
		}
		if (other.PassengerId != 0)
		{
			PassengerId = other.PassengerId;
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
			case 26u:
				if (dGFGNMJALGJ_ == null)
				{
					DGFGNMJALGJ = new DKBNGDHCNCH();
				}
				input.ReadMessage(DGFGNMJALGJ);
				break;
			case 56u:
				PassengerId = input.ReadUInt32();
				break;
			}
		}
	}
}
