using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CCKLMNCPGFO : IMessage<CCKLMNCPGFO>, IMessage, IEquatable<CCKLMNCPGFO>, IDeepCloneable<CCKLMNCPGFO>, IBufferMessage
{
	private static readonly MessageParser<CCKLMNCPGFO> _parser = new MessageParser<CCKLMNCPGFO>(() => new CCKLMNCPGFO());

	private UnknownFieldSet _unknownFields;

	public const int FKIPLPCJOGNFieldNumber = 1;

	private IGADHIBKNPA fKIPLPCJOGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CCKLMNCPGFO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CCKLMNCPGFOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGADHIBKNPA FKIPLPCJOGN
	{
		get
		{
			return fKIPLPCJOGN_;
		}
		set
		{
			fKIPLPCJOGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCKLMNCPGFO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCKLMNCPGFO(CCKLMNCPGFO other)
		: this()
	{
		fKIPLPCJOGN_ = ((other.fKIPLPCJOGN_ != null) ? other.fKIPLPCJOGN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCKLMNCPGFO Clone()
	{
		return new CCKLMNCPGFO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CCKLMNCPGFO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CCKLMNCPGFO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FKIPLPCJOGN, other.FKIPLPCJOGN))
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
		if (fKIPLPCJOGN_ != null)
		{
			num ^= FKIPLPCJOGN.GetHashCode();
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
		if (fKIPLPCJOGN_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(FKIPLPCJOGN);
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
		if (fKIPLPCJOGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FKIPLPCJOGN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CCKLMNCPGFO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fKIPLPCJOGN_ != null)
		{
			if (fKIPLPCJOGN_ == null)
			{
				FKIPLPCJOGN = new IGADHIBKNPA();
			}
			FKIPLPCJOGN.MergeFrom(other.FKIPLPCJOGN);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (fKIPLPCJOGN_ == null)
			{
				FKIPLPCJOGN = new IGADHIBKNPA();
			}
			input.ReadMessage(FKIPLPCJOGN);
		}
	}
}
