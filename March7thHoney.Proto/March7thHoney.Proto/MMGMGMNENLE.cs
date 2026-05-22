using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MMGMGMNENLE : IMessage<MMGMGMNENLE>, IMessage, IEquatable<MMGMGMNENLE>, IDeepCloneable<MMGMGMNENLE>, IBufferMessage
{
	private static readonly MessageParser<MMGMGMNENLE> _parser = new MessageParser<MMGMGMNENLE>(() => new MMGMGMNENLE());

	private UnknownFieldSet _unknownFields;

	public const int JPPGFLJHDHKFieldNumber = 10;

	private EOOABBDPEJJ jPPGFLJHDHK_;

	public const int SourceFieldNumber = 12;

	private OMLONGNOMAI source_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MMGMGMNENLE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MMGMGMNENLEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOOABBDPEJJ JPPGFLJHDHK
	{
		get
		{
			return jPPGFLJHDHK_;
		}
		set
		{
			jPPGFLJHDHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMLONGNOMAI Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMGMGMNENLE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMGMGMNENLE(MMGMGMNENLE other)
		: this()
	{
		jPPGFLJHDHK_ = ((other.jPPGFLJHDHK_ != null) ? other.jPPGFLJHDHK_.Clone() : null);
		source_ = ((other.source_ != null) ? other.source_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMGMGMNENLE Clone()
	{
		return new MMGMGMNENLE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MMGMGMNENLE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MMGMGMNENLE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JPPGFLJHDHK, other.JPPGFLJHDHK))
		{
			return false;
		}
		if (!object.Equals(Source, other.Source))
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
		if (jPPGFLJHDHK_ != null)
		{
			num ^= JPPGFLJHDHK.GetHashCode();
		}
		if (source_ != null)
		{
			num ^= Source.GetHashCode();
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
		if (jPPGFLJHDHK_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(JPPGFLJHDHK);
		}
		if (source_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(Source);
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
		if (jPPGFLJHDHK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JPPGFLJHDHK);
		}
		if (source_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Source);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MMGMGMNENLE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jPPGFLJHDHK_ != null)
		{
			if (jPPGFLJHDHK_ == null)
			{
				JPPGFLJHDHK = new EOOABBDPEJJ();
			}
			JPPGFLJHDHK.MergeFrom(other.JPPGFLJHDHK);
		}
		if (other.source_ != null)
		{
			if (source_ == null)
			{
				Source = new OMLONGNOMAI();
			}
			Source.MergeFrom(other.Source);
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
			case 82u:
				if (jPPGFLJHDHK_ == null)
				{
					JPPGFLJHDHK = new EOOABBDPEJJ();
				}
				input.ReadMessage(JPPGFLJHDHK);
				break;
			case 98u:
				if (source_ == null)
				{
					Source = new OMLONGNOMAI();
				}
				input.ReadMessage(Source);
				break;
			}
		}
	}
}
