using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GCOBCGDDNII : IMessage<GCOBCGDDNII>, IMessage, IEquatable<GCOBCGDDNII>, IDeepCloneable<GCOBCGDDNII>, IBufferMessage
{
	private static readonly MessageParser<GCOBCGDDNII> _parser = new MessageParser<GCOBCGDDNII>(() => new GCOBCGDDNII());

	private UnknownFieldSet _unknownFields;

	public const int LKNHKFIGBDFFieldNumber = 11;

	private APHLJPLBOIF lKNHKFIGBDF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GCOBCGDDNII> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GCOBCGDDNIIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APHLJPLBOIF LKNHKFIGBDF
	{
		get
		{
			return lKNHKFIGBDF_;
		}
		set
		{
			lKNHKFIGBDF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCOBCGDDNII()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCOBCGDDNII(GCOBCGDDNII other)
		: this()
	{
		lKNHKFIGBDF_ = ((other.lKNHKFIGBDF_ != null) ? other.lKNHKFIGBDF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCOBCGDDNII Clone()
	{
		return new GCOBCGDDNII(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GCOBCGDDNII);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GCOBCGDDNII other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LKNHKFIGBDF, other.LKNHKFIGBDF))
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
		if (lKNHKFIGBDF_ != null)
		{
			num ^= LKNHKFIGBDF.GetHashCode();
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
		if (lKNHKFIGBDF_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(LKNHKFIGBDF);
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
		if (lKNHKFIGBDF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LKNHKFIGBDF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GCOBCGDDNII other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lKNHKFIGBDF_ != null)
		{
			if (lKNHKFIGBDF_ == null)
			{
				LKNHKFIGBDF = new APHLJPLBOIF();
			}
			LKNHKFIGBDF.MergeFrom(other.LKNHKFIGBDF);
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
			if (num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (lKNHKFIGBDF_ == null)
			{
				LKNHKFIGBDF = new APHLJPLBOIF();
			}
			input.ReadMessage(LKNHKFIGBDF);
		}
	}
}
