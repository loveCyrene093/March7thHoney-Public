using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BLDLMHPFBCM : IMessage<BLDLMHPFBCM>, IMessage, IEquatable<BLDLMHPFBCM>, IDeepCloneable<BLDLMHPFBCM>, IBufferMessage
{
	private static readonly MessageParser<BLDLMHPFBCM> _parser = new MessageParser<BLDLMHPFBCM>(() => new BLDLMHPFBCM());

	private UnknownFieldSet _unknownFields;

	public const int PFBBHAMOAGBFieldNumber = 13;

	private HNCKGFGHJAC pFBBHAMOAGB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BLDLMHPFBCM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BLDLMHPFBCMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HNCKGFGHJAC PFBBHAMOAGB
	{
		get
		{
			return pFBBHAMOAGB_;
		}
		set
		{
			pFBBHAMOAGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLDLMHPFBCM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLDLMHPFBCM(BLDLMHPFBCM other)
		: this()
	{
		pFBBHAMOAGB_ = ((other.pFBBHAMOAGB_ != null) ? other.pFBBHAMOAGB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLDLMHPFBCM Clone()
	{
		return new BLDLMHPFBCM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BLDLMHPFBCM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BLDLMHPFBCM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PFBBHAMOAGB, other.PFBBHAMOAGB))
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
		if (pFBBHAMOAGB_ != null)
		{
			num ^= PFBBHAMOAGB.GetHashCode();
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
		if (pFBBHAMOAGB_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(PFBBHAMOAGB);
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
		if (pFBBHAMOAGB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PFBBHAMOAGB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BLDLMHPFBCM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pFBBHAMOAGB_ != null)
		{
			if (pFBBHAMOAGB_ == null)
			{
				PFBBHAMOAGB = new HNCKGFGHJAC();
			}
			PFBBHAMOAGB.MergeFrom(other.PFBBHAMOAGB);
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
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (pFBBHAMOAGB_ == null)
			{
				PFBBHAMOAGB = new HNCKGFGHJAC();
			}
			input.ReadMessage(PFBBHAMOAGB);
		}
	}
}
