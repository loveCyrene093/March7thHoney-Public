using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AOOLDKDFOBO : IMessage<AOOLDKDFOBO>, IMessage, IEquatable<AOOLDKDFOBO>, IDeepCloneable<AOOLDKDFOBO>, IBufferMessage
{
	private static readonly MessageParser<AOOLDKDFOBO> _parser = new MessageParser<AOOLDKDFOBO>(() => new AOOLDKDFOBO());

	private UnknownFieldSet _unknownFields;

	public const int SourceFieldNumber = 8;

	private FFLIMLMFABP source_;

	public const int JPPGFLJHDHKFieldNumber = 14;

	private AMKAGKFOFBN jPPGFLJHDHK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AOOLDKDFOBO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AOOLDKDFOBOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFLIMLMFABP Source
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
	public AMKAGKFOFBN JPPGFLJHDHK
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
	public AOOLDKDFOBO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOOLDKDFOBO(AOOLDKDFOBO other)
		: this()
	{
		source_ = other.source_;
		jPPGFLJHDHK_ = ((other.jPPGFLJHDHK_ != null) ? other.jPPGFLJHDHK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOOLDKDFOBO Clone()
	{
		return new AOOLDKDFOBO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AOOLDKDFOBO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AOOLDKDFOBO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Source != other.Source)
		{
			return false;
		}
		if (!object.Equals(JPPGFLJHDHK, other.JPPGFLJHDHK))
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
		if (Source != FFLIMLMFABP.Pcpdhelpkem)
		{
			num ^= Source.GetHashCode();
		}
		if (jPPGFLJHDHK_ != null)
		{
			num ^= JPPGFLJHDHK.GetHashCode();
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
		if (Source != FFLIMLMFABP.Pcpdhelpkem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)Source);
		}
		if (jPPGFLJHDHK_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(JPPGFLJHDHK);
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
		if (Source != FFLIMLMFABP.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Source);
		}
		if (jPPGFLJHDHK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JPPGFLJHDHK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AOOLDKDFOBO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Source != FFLIMLMFABP.Pcpdhelpkem)
		{
			Source = other.Source;
		}
		if (other.jPPGFLJHDHK_ != null)
		{
			if (jPPGFLJHDHK_ == null)
			{
				JPPGFLJHDHK = new AMKAGKFOFBN();
			}
			JPPGFLJHDHK.MergeFrom(other.JPPGFLJHDHK);
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
			case 64u:
				Source = (FFLIMLMFABP)input.ReadEnum();
				break;
			case 114u:
				if (jPPGFLJHDHK_ == null)
				{
					JPPGFLJHDHK = new AMKAGKFOFBN();
				}
				input.ReadMessage(JPPGFLJHDHK);
				break;
			}
		}
	}
}
