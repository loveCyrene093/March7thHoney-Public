using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueUpdateAeonModifierValueScNotify : IMessage<ChessRogueUpdateAeonModifierValueScNotify>, IMessage, IEquatable<ChessRogueUpdateAeonModifierValueScNotify>, IDeepCloneable<ChessRogueUpdateAeonModifierValueScNotify>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueUpdateAeonModifierValueScNotify> _parser = new MessageParser<ChessRogueUpdateAeonModifierValueScNotify>(() => new ChessRogueUpdateAeonModifierValueScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CGNOKHABCPPFieldNumber = 11;

	private int cGNOKHABCPP_;

	public const int LGHOOKMNMCLFieldNumber = 14;

	private uint lGHOOKMNMCL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueUpdateAeonModifierValueScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueUpdateAeonModifierValueScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CGNOKHABCPP
	{
		get
		{
			return cGNOKHABCPP_;
		}
		set
		{
			cGNOKHABCPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LGHOOKMNMCL
	{
		get
		{
			return lGHOOKMNMCL_;
		}
		set
		{
			lGHOOKMNMCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateAeonModifierValueScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateAeonModifierValueScNotify(ChessRogueUpdateAeonModifierValueScNotify other)
		: this()
	{
		cGNOKHABCPP_ = other.cGNOKHABCPP_;
		lGHOOKMNMCL_ = other.lGHOOKMNMCL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateAeonModifierValueScNotify Clone()
	{
		return new ChessRogueUpdateAeonModifierValueScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueUpdateAeonModifierValueScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueUpdateAeonModifierValueScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CGNOKHABCPP != other.CGNOKHABCPP)
		{
			return false;
		}
		if (LGHOOKMNMCL != other.LGHOOKMNMCL)
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
		if (CGNOKHABCPP != 0)
		{
			num ^= CGNOKHABCPP.GetHashCode();
		}
		if (LGHOOKMNMCL != 0)
		{
			num ^= LGHOOKMNMCL.GetHashCode();
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
		if (CGNOKHABCPP != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(CGNOKHABCPP);
		}
		if (LGHOOKMNMCL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LGHOOKMNMCL);
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
		if (CGNOKHABCPP != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CGNOKHABCPP);
		}
		if (LGHOOKMNMCL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LGHOOKMNMCL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueUpdateAeonModifierValueScNotify other)
	{
		if (other != null)
		{
			if (other.CGNOKHABCPP != 0)
			{
				CGNOKHABCPP = other.CGNOKHABCPP;
			}
			if (other.LGHOOKMNMCL != 0)
			{
				LGHOOKMNMCL = other.LGHOOKMNMCL;
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
			case 88u:
				CGNOKHABCPP = input.ReadInt32();
				break;
			case 112u:
				LGHOOKMNMCL = input.ReadUInt32();
				break;
			}
		}
	}
}
