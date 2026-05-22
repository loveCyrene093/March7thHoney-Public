using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BIDGPELJPJK : IMessage<BIDGPELJPJK>, IMessage, IEquatable<BIDGPELJPJK>, IDeepCloneable<BIDGPELJPJK>, IBufferMessage
{
	private static readonly MessageParser<BIDGPELJPJK> _parser = new MessageParser<BIDGPELJPJK>(() => new BIDGPELJPJK());

	private UnknownFieldSet _unknownFields;

	public const int StateFieldNumber = 9;

	private uint state_;

	public const int JHDLNBPNEKGFieldNumber = 15;

	private uint jHDLNBPNEKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BIDGPELJPJK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BIDGPELJPJKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHDLNBPNEKG
	{
		get
		{
			return jHDLNBPNEKG_;
		}
		set
		{
			jHDLNBPNEKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIDGPELJPJK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIDGPELJPJK(BIDGPELJPJK other)
		: this()
	{
		state_ = other.state_;
		jHDLNBPNEKG_ = other.jHDLNBPNEKG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BIDGPELJPJK Clone()
	{
		return new BIDGPELJPJK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BIDGPELJPJK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BIDGPELJPJK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (State != other.State)
		{
			return false;
		}
		if (JHDLNBPNEKG != other.JHDLNBPNEKG)
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
		if (State != 0)
		{
			num ^= State.GetHashCode();
		}
		if (JHDLNBPNEKG != 0)
		{
			num ^= JHDLNBPNEKG.GetHashCode();
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
		if (State != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(State);
		}
		if (JHDLNBPNEKG != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(JHDLNBPNEKG);
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
		if (State != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(State);
		}
		if (JHDLNBPNEKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHDLNBPNEKG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BIDGPELJPJK other)
	{
		if (other != null)
		{
			if (other.State != 0)
			{
				State = other.State;
			}
			if (other.JHDLNBPNEKG != 0)
			{
				JHDLNBPNEKG = other.JHDLNBPNEKG;
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
			case 72u:
				State = input.ReadUInt32();
				break;
			case 120u:
				JHDLNBPNEKG = input.ReadUInt32();
				break;
			}
		}
	}
}
