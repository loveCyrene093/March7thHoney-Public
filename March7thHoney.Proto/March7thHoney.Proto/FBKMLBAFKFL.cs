using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FBKMLBAFKFL : IMessage<FBKMLBAFKFL>, IMessage, IEquatable<FBKMLBAFKFL>, IDeepCloneable<FBKMLBAFKFL>, IBufferMessage
{
	private static readonly MessageParser<FBKMLBAFKFL> _parser = new MessageParser<FBKMLBAFKFL>(() => new FBKMLBAFKFL());

	private UnknownFieldSet _unknownFields;

	public const int CEAKOOAOJLFFieldNumber = 15;

	private ALEOILCIFIN cEAKOOAOJLF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FBKMLBAFKFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FBKMLBAFKFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALEOILCIFIN CEAKOOAOJLF
	{
		get
		{
			return cEAKOOAOJLF_;
		}
		set
		{
			cEAKOOAOJLF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBKMLBAFKFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBKMLBAFKFL(FBKMLBAFKFL other)
		: this()
	{
		cEAKOOAOJLF_ = ((other.cEAKOOAOJLF_ != null) ? other.cEAKOOAOJLF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBKMLBAFKFL Clone()
	{
		return new FBKMLBAFKFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FBKMLBAFKFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FBKMLBAFKFL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CEAKOOAOJLF, other.CEAKOOAOJLF))
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
		if (cEAKOOAOJLF_ != null)
		{
			num ^= CEAKOOAOJLF.GetHashCode();
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
		if (cEAKOOAOJLF_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(CEAKOOAOJLF);
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
		if (cEAKOOAOJLF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CEAKOOAOJLF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FBKMLBAFKFL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cEAKOOAOJLF_ != null)
		{
			if (cEAKOOAOJLF_ == null)
			{
				CEAKOOAOJLF = new ALEOILCIFIN();
			}
			CEAKOOAOJLF.MergeFrom(other.CEAKOOAOJLF);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (cEAKOOAOJLF_ == null)
			{
				CEAKOOAOJLF = new ALEOILCIFIN();
			}
			input.ReadMessage(CEAKOOAOJLF);
		}
	}
}
