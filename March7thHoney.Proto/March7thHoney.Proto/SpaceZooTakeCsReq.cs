using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpaceZooTakeCsReq : IMessage<SpaceZooTakeCsReq>, IMessage, IEquatable<SpaceZooTakeCsReq>, IDeepCloneable<SpaceZooTakeCsReq>, IBufferMessage
{
	private static readonly MessageParser<SpaceZooTakeCsReq> _parser = new MessageParser<SpaceZooTakeCsReq>(() => new SpaceZooTakeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BMLKIBNLNJAFieldNumber = 11;

	private uint bMLKIBNLNJA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpaceZooTakeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpaceZooTakeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BMLKIBNLNJA
	{
		get
		{
			return bMLKIBNLNJA_;
		}
		set
		{
			bMLKIBNLNJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooTakeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooTakeCsReq(SpaceZooTakeCsReq other)
		: this()
	{
		bMLKIBNLNJA_ = other.bMLKIBNLNJA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooTakeCsReq Clone()
	{
		return new SpaceZooTakeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpaceZooTakeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpaceZooTakeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BMLKIBNLNJA != other.BMLKIBNLNJA)
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
		if (BMLKIBNLNJA != 0)
		{
			num ^= BMLKIBNLNJA.GetHashCode();
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
		if (BMLKIBNLNJA != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(BMLKIBNLNJA);
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
		if (BMLKIBNLNJA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BMLKIBNLNJA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpaceZooTakeCsReq other)
	{
		if (other != null)
		{
			if (other.BMLKIBNLNJA != 0)
			{
				BMLKIBNLNJA = other.BMLKIBNLNJA;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				BMLKIBNLNJA = input.ReadUInt32();
			}
		}
	}
}
