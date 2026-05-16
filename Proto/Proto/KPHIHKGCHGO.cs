using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KPHIHKGCHGO : IMessage<KPHIHKGCHGO>, IMessage, IEquatable<KPHIHKGCHGO>, IDeepCloneable<KPHIHKGCHGO>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		LJBLFMDFHJE = 13,
		FNMBIIGCLBJ = 14
	}

	private static readonly MessageParser<KPHIHKGCHGO> _parser = new MessageParser<KPHIHKGCHGO>(() => new KPHIHKGCHGO());

	private UnknownFieldSet _unknownFields;

	public const int LJBLFMDFHJEFieldNumber = 13;

	public const int FNMBIIGCLBJFieldNumber = 14;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KPHIHKGCHGO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KPHIHKGCHGOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMLIJLEKBEA LJBLFMDFHJE
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LJBLFMDFHJE)
			{
				return null;
			}
			return (JMLIJLEKBEA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LJBLFMDFHJE : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAJKNHILCEA FNMBIIGCLBJ
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FNMBIIGCLBJ)
			{
				return null;
			}
			return (DAJKNHILCEA)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FNMBIIGCLBJ : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPHIHKGCHGO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPHIHKGCHGO(KPHIHKGCHGO other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.LJBLFMDFHJE:
			LJBLFMDFHJE = other.LJBLFMDFHJE.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FNMBIIGCLBJ:
			FNMBIIGCLBJ = other.FNMBIIGCLBJ.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPHIHKGCHGO Clone()
	{
		return new KPHIHKGCHGO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KPHIHKGCHGO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KPHIHKGCHGO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LJBLFMDFHJE, other.LJBLFMDFHJE))
		{
			return false;
		}
		if (!object.Equals(FNMBIIGCLBJ, other.FNMBIIGCLBJ))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LJBLFMDFHJE)
		{
			num ^= LJBLFMDFHJE.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FNMBIIGCLBJ)
		{
			num ^= FNMBIIGCLBJ.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LJBLFMDFHJE)
		{
			output.WriteRawTag(106);
			output.WriteMessage(LJBLFMDFHJE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FNMBIIGCLBJ)
		{
			output.WriteRawTag(114);
			output.WriteMessage(FNMBIIGCLBJ);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LJBLFMDFHJE)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJBLFMDFHJE);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FNMBIIGCLBJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FNMBIIGCLBJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KPHIHKGCHGO other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.LJBLFMDFHJE:
			if (LJBLFMDFHJE == null)
			{
				LJBLFMDFHJE = new JMLIJLEKBEA();
			}
			LJBLFMDFHJE.MergeFrom(other.LJBLFMDFHJE);
			break;
		case BPIHFAJCLOCOneofCase.FNMBIIGCLBJ:
			if (FNMBIIGCLBJ == null)
			{
				FNMBIIGCLBJ = new DAJKNHILCEA();
			}
			FNMBIIGCLBJ.MergeFrom(other.FNMBIIGCLBJ);
			break;
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
			case 106u:
			{
				JMLIJLEKBEA jMLIJLEKBEA = new JMLIJLEKBEA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LJBLFMDFHJE)
				{
					jMLIJLEKBEA.MergeFrom(LJBLFMDFHJE);
				}
				input.ReadMessage(jMLIJLEKBEA);
				LJBLFMDFHJE = jMLIJLEKBEA;
				break;
			}
			case 114u:
			{
				DAJKNHILCEA dAJKNHILCEA = new DAJKNHILCEA();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FNMBIIGCLBJ)
				{
					dAJKNHILCEA.MergeFrom(FNMBIIGCLBJ);
				}
				input.ReadMessage(dAJKNHILCEA);
				FNMBIIGCLBJ = dAJKNHILCEA;
				break;
			}
			}
		}
	}
}
