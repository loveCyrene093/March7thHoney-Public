using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JKONPIILNJK : IMessage<JKONPIILNJK>, IMessage, IEquatable<JKONPIILNJK>, IDeepCloneable<JKONPIILNJK>, IBufferMessage
{
	private static readonly MessageParser<JKONPIILNJK> _parser = new MessageParser<JKONPIILNJK>(() => new JKONPIILNJK());

	private UnknownFieldSet _unknownFields;

	public const int TitleFieldNumber = 5;

	private string title_ = "";

	public const int MOBBPMMKKMIFieldNumber = 14;

	private uint mOBBPMMKKMI_;

	public const int FCOKOGNOGCAFieldNumber = 15;

	private uint fCOKOGNOGCA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JKONPIILNJK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JKONPIILNJKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Title
	{
		get
		{
			return title_;
		}
		set
		{
			title_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOBBPMMKKMI
	{
		get
		{
			return mOBBPMMKKMI_;
		}
		set
		{
			mOBBPMMKKMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCOKOGNOGCA
	{
		get
		{
			return fCOKOGNOGCA_;
		}
		set
		{
			fCOKOGNOGCA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKONPIILNJK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKONPIILNJK(JKONPIILNJK other)
		: this()
	{
		title_ = other.title_;
		mOBBPMMKKMI_ = other.mOBBPMMKKMI_;
		fCOKOGNOGCA_ = other.fCOKOGNOGCA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKONPIILNJK Clone()
	{
		return new JKONPIILNJK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JKONPIILNJK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JKONPIILNJK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Title != other.Title)
		{
			return false;
		}
		if (MOBBPMMKKMI != other.MOBBPMMKKMI)
		{
			return false;
		}
		if (FCOKOGNOGCA != other.FCOKOGNOGCA)
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
		if (Title.Length != 0)
		{
			num ^= Title.GetHashCode();
		}
		if (MOBBPMMKKMI != 0)
		{
			num ^= MOBBPMMKKMI.GetHashCode();
		}
		if (FCOKOGNOGCA != 0)
		{
			num ^= FCOKOGNOGCA.GetHashCode();
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
		if (Title.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Title);
		}
		if (MOBBPMMKKMI != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MOBBPMMKKMI);
		}
		if (FCOKOGNOGCA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FCOKOGNOGCA);
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
		if (Title.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Title);
		}
		if (MOBBPMMKKMI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOBBPMMKKMI);
		}
		if (FCOKOGNOGCA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCOKOGNOGCA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JKONPIILNJK other)
	{
		if (other != null)
		{
			if (other.Title.Length != 0)
			{
				Title = other.Title;
			}
			if (other.MOBBPMMKKMI != 0)
			{
				MOBBPMMKKMI = other.MOBBPMMKKMI;
			}
			if (other.FCOKOGNOGCA != 0)
			{
				FCOKOGNOGCA = other.FCOKOGNOGCA;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 42u:
				Title = input.ReadString();
				break;
			case 112u:
				MOBBPMMKKMI = input.ReadUInt32();
				break;
			case 120u:
				FCOKOGNOGCA = input.ReadUInt32();
				break;
			}
		}
	}
}
