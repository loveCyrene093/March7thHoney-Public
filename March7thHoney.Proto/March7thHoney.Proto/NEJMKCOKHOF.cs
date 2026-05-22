using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NEJMKCOKHOF : IMessage<NEJMKCOKHOF>, IMessage, IEquatable<NEJMKCOKHOF>, IDeepCloneable<NEJMKCOKHOF>, IBufferMessage
{
	private static readonly MessageParser<NEJMKCOKHOF> _parser = new MessageParser<NEJMKCOKHOF>(() => new NEJMKCOKHOF());

	private UnknownFieldSet _unknownFields;

	public const int PEABLDFCMICFieldNumber = 2;

	private PMCGOFCMHHA pEABLDFCMIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NEJMKCOKHOF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NEJMKCOKHOFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMCGOFCMHHA PEABLDFCMIC
	{
		get
		{
			return pEABLDFCMIC_;
		}
		set
		{
			pEABLDFCMIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEJMKCOKHOF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEJMKCOKHOF(NEJMKCOKHOF other)
		: this()
	{
		pEABLDFCMIC_ = ((other.pEABLDFCMIC_ != null) ? other.pEABLDFCMIC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEJMKCOKHOF Clone()
	{
		return new NEJMKCOKHOF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NEJMKCOKHOF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NEJMKCOKHOF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PEABLDFCMIC, other.PEABLDFCMIC))
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
		if (pEABLDFCMIC_ != null)
		{
			num ^= PEABLDFCMIC.GetHashCode();
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
		if (pEABLDFCMIC_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(PEABLDFCMIC);
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
		if (pEABLDFCMIC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PEABLDFCMIC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NEJMKCOKHOF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pEABLDFCMIC_ != null)
		{
			if (pEABLDFCMIC_ == null)
			{
				PEABLDFCMIC = new PMCGOFCMHHA();
			}
			PEABLDFCMIC.MergeFrom(other.PEABLDFCMIC);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (pEABLDFCMIC_ == null)
			{
				PEABLDFCMIC = new PMCGOFCMHHA();
			}
			input.ReadMessage(PEABLDFCMIC);
		}
	}
}
