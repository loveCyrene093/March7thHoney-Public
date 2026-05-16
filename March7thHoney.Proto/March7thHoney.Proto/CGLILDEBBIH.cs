using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CGLILDEBBIH : IMessage<CGLILDEBBIH>, IMessage, IEquatable<CGLILDEBBIH>, IDeepCloneable<CGLILDEBBIH>, IBufferMessage
{
	private static readonly MessageParser<CGLILDEBBIH> _parser = new MessageParser<CGLILDEBBIH>(() => new CGLILDEBBIH());

	private UnknownFieldSet _unknownFields;

	public const int KNPMHOLAJFKFieldNumber = 3;

	private CEGOPFBELBL kNPMHOLAJFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CGLILDEBBIH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CGLILDEBBIHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEGOPFBELBL KNPMHOLAJFK
	{
		get
		{
			return kNPMHOLAJFK_;
		}
		set
		{
			kNPMHOLAJFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGLILDEBBIH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGLILDEBBIH(CGLILDEBBIH other)
		: this()
	{
		kNPMHOLAJFK_ = ((other.kNPMHOLAJFK_ != null) ? other.kNPMHOLAJFK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGLILDEBBIH Clone()
	{
		return new CGLILDEBBIH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CGLILDEBBIH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CGLILDEBBIH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KNPMHOLAJFK, other.KNPMHOLAJFK))
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
		if (kNPMHOLAJFK_ != null)
		{
			num ^= KNPMHOLAJFK.GetHashCode();
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
		if (kNPMHOLAJFK_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(KNPMHOLAJFK);
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
		if (kNPMHOLAJFK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KNPMHOLAJFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CGLILDEBBIH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kNPMHOLAJFK_ != null)
		{
			if (kNPMHOLAJFK_ == null)
			{
				KNPMHOLAJFK = new CEGOPFBELBL();
			}
			KNPMHOLAJFK.MergeFrom(other.KNPMHOLAJFK);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (kNPMHOLAJFK_ == null)
			{
				KNPMHOLAJFK = new CEGOPFBELBL();
			}
			input.ReadMessage(KNPMHOLAJFK);
		}
	}
}
