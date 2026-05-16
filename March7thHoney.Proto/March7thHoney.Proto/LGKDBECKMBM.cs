using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LGKDBECKMBM : IMessage<LGKDBECKMBM>, IMessage, IEquatable<LGKDBECKMBM>, IDeepCloneable<LGKDBECKMBM>, IBufferMessage
{
	private static readonly MessageParser<LGKDBECKMBM> _parser = new MessageParser<LGKDBECKMBM>(() => new LGKDBECKMBM());

	private UnknownFieldSet _unknownFields;

	public const int JKPADPHCOJJFieldNumber = 9;

	private FGPEFEELOCO jKPADPHCOJJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LGKDBECKMBM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LGKDBECKMBMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FGPEFEELOCO JKPADPHCOJJ
	{
		get
		{
			return jKPADPHCOJJ_;
		}
		set
		{
			jKPADPHCOJJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGKDBECKMBM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGKDBECKMBM(LGKDBECKMBM other)
		: this()
	{
		jKPADPHCOJJ_ = ((other.jKPADPHCOJJ_ != null) ? other.jKPADPHCOJJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGKDBECKMBM Clone()
	{
		return new LGKDBECKMBM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LGKDBECKMBM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LGKDBECKMBM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JKPADPHCOJJ, other.JKPADPHCOJJ))
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
		if (jKPADPHCOJJ_ != null)
		{
			num ^= JKPADPHCOJJ.GetHashCode();
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
		if (jKPADPHCOJJ_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(JKPADPHCOJJ);
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
		if (jKPADPHCOJJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JKPADPHCOJJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LGKDBECKMBM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jKPADPHCOJJ_ != null)
		{
			if (jKPADPHCOJJ_ == null)
			{
				JKPADPHCOJJ = new FGPEFEELOCO();
			}
			JKPADPHCOJJ.MergeFrom(other.JKPADPHCOJJ);
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
			if (num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (jKPADPHCOJJ_ == null)
			{
				JKPADPHCOJJ = new FGPEFEELOCO();
			}
			input.ReadMessage(JKPADPHCOJJ);
		}
	}
}
