using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OpenRelicBoxCsReq : IMessage<OpenRelicBoxCsReq>, IMessage, IEquatable<OpenRelicBoxCsReq>, IDeepCloneable<OpenRelicBoxCsReq>, IBufferMessage
{
	private static readonly MessageParser<OpenRelicBoxCsReq> _parser = new MessageParser<OpenRelicBoxCsReq>(() => new OpenRelicBoxCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GPEAFAJGCPHFieldNumber = 6;

	private OMHAOBFKIKE gPEAFAJGCPH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OpenRelicBoxCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OpenRelicBoxCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMHAOBFKIKE GPEAFAJGCPH
	{
		get
		{
			return gPEAFAJGCPH_;
		}
		set
		{
			gPEAFAJGCPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenRelicBoxCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenRelicBoxCsReq(OpenRelicBoxCsReq other)
		: this()
	{
		gPEAFAJGCPH_ = ((other.gPEAFAJGCPH_ != null) ? other.gPEAFAJGCPH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenRelicBoxCsReq Clone()
	{
		return new OpenRelicBoxCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OpenRelicBoxCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OpenRelicBoxCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GPEAFAJGCPH, other.GPEAFAJGCPH))
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
		if (gPEAFAJGCPH_ != null)
		{
			num ^= GPEAFAJGCPH.GetHashCode();
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
		if (gPEAFAJGCPH_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(GPEAFAJGCPH);
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
		if (gPEAFAJGCPH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GPEAFAJGCPH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OpenRelicBoxCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gPEAFAJGCPH_ != null)
		{
			if (gPEAFAJGCPH_ == null)
			{
				GPEAFAJGCPH = new OMHAOBFKIKE();
			}
			GPEAFAJGCPH.MergeFrom(other.GPEAFAJGCPH);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (gPEAFAJGCPH_ == null)
			{
				GPEAFAJGCPH = new OMHAOBFKIKE();
			}
			input.ReadMessage(GPEAFAJGCPH);
		}
	}
}
