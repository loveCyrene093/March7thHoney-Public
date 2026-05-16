using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GKDDGHBGGAM : IMessage<GKDDGHBGGAM>, IMessage, IEquatable<GKDDGHBGGAM>, IDeepCloneable<GKDDGHBGGAM>, IBufferMessage
{
	private static readonly MessageParser<GKDDGHBGGAM> _parser = new MessageParser<GKDDGHBGGAM>(() => new GKDDGHBGGAM());

	private UnknownFieldSet _unknownFields;

	public const int EJCEIOMIOOPFieldNumber = 5;

	private AGBLLFGOBKE eJCEIOMIOOP_;

	public const int BILBCIJBACNFieldNumber = 13;

	private int bILBCIJBACN_;

	public const int UniqueIdFieldNumber = 15;

	private int uniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GKDDGHBGGAM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GKDDGHBGGAMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGBLLFGOBKE EJCEIOMIOOP
	{
		get
		{
			return eJCEIOMIOOP_;
		}
		set
		{
			eJCEIOMIOOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BILBCIJBACN
	{
		get
		{
			return bILBCIJBACN_;
		}
		set
		{
			bILBCIJBACN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int UniqueId
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
	public GKDDGHBGGAM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GKDDGHBGGAM(GKDDGHBGGAM other)
		: this()
	{
		eJCEIOMIOOP_ = ((other.eJCEIOMIOOP_ != null) ? other.eJCEIOMIOOP_.Clone() : null);
		bILBCIJBACN_ = other.bILBCIJBACN_;
		uniqueId_ = other.uniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GKDDGHBGGAM Clone()
	{
		return new GKDDGHBGGAM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GKDDGHBGGAM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GKDDGHBGGAM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EJCEIOMIOOP, other.EJCEIOMIOOP))
		{
			return false;
		}
		if (BILBCIJBACN != other.BILBCIJBACN)
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
		if (eJCEIOMIOOP_ != null)
		{
			num ^= EJCEIOMIOOP.GetHashCode();
		}
		if (BILBCIJBACN != 0)
		{
			num ^= BILBCIJBACN.GetHashCode();
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
		if (eJCEIOMIOOP_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(EJCEIOMIOOP);
		}
		if (BILBCIJBACN != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(BILBCIJBACN);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(UniqueId);
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
		if (eJCEIOMIOOP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EJCEIOMIOOP);
		}
		if (BILBCIJBACN != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BILBCIJBACN);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GKDDGHBGGAM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eJCEIOMIOOP_ != null)
		{
			if (eJCEIOMIOOP_ == null)
			{
				EJCEIOMIOOP = new AGBLLFGOBKE();
			}
			EJCEIOMIOOP.MergeFrom(other.EJCEIOMIOOP);
		}
		if (other.BILBCIJBACN != 0)
		{
			BILBCIJBACN = other.BILBCIJBACN;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
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
			case 42u:
				if (eJCEIOMIOOP_ == null)
				{
					EJCEIOMIOOP = new AGBLLFGOBKE();
				}
				input.ReadMessage(EJCEIOMIOOP);
				break;
			case 104u:
				BILBCIJBACN = input.ReadInt32();
				break;
			case 120u:
				UniqueId = input.ReadInt32();
				break;
			}
		}
	}
}
